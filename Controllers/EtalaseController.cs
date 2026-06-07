using Npgsql;
using SIKOPI_DOPY_ROASTERY.Data;
using SIKOPI_DOPY_ROASTERY.Helpers;
using SIKOPI_DOPY_ROASTERY.Models;
using SIKOPI_DOPY_ROASTERY.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIKOPI_DOPY_ROASTERY.Controllers
{
    public class EtalaseController
    {
        private readonly RepositoriRoastBean _repoRoast;
        public EtalaseController(RepositoriRoastBean repoRoast) { _repoRoast = repoRoast; }  // CONSTRUCTOR injection

        // Produk yang BOLEH dijual: sudah diberi harga (>0) dan masih ada stok (>0)
        public List<RoastBean> DaftarProdukSiapJual()
        {
            var hasil = new List<RoastBean>();
            foreach (var r in _repoRoast.DapatkanSemua())
            {
                if (r.HargaPerGram > 0 && r.StokGram > 0)
                    hasil.Add(r);
            }
            return hasil;
        }

        // Proses 1 penjualan single-item (1 produk per transaksi)
        public void Jual(long idRoast, string namaPelanggan, decimal qtyGram)
        {
            var produk = _repoRoast.DapatkanById(idRoast);
            if (produk == null) throw new ArgumentException("Produk tidak ditemukan");
            if (produk.HargaPerGram <= 0) throw new ArgumentException("Produk belum diberi harga oleh admin");
            if (qtyGram <= 0) throw new ArgumentException("Jumlah gram harus lebih dari 0");
            if (qtyGram > produk.StokGram) throw new ArgumentException("Stok produk tidak cukup");

            decimal hargaPerGram = produk.HargaPerGram;
            decimal total = qtyGram * hargaPerGram;
            string invoice = $"INV-{DateTime.Now:yyyyMMddHHmmss}";

            // Semua langkah harus sukses bersama -> pakai TRANSACTION (seperti Roasting)
            using var koneksi = new NpgsqlConnection(KoneksiDb.ConnStr);
            koneksi.Open();
            using var trx = koneksi.BeginTransaction();
            try
            {
                // 1) simpan header penjualan
                var cmdJual = new NpgsqlCommand(
                    "INSERT INTO penjualan (nomor_invoice, id_karyawan_penjualan, nama_pelanggan, total_penjualan) " +
                    "VALUES (@inv,@kasir,@pelanggan,@total) RETURNING id_penjualan", koneksi, trx);
                cmdJual.Parameters.AddWithValue("@inv", invoice);
                cmdJual.Parameters.AddWithValue("@kasir", SesiAktif.PenggunaSaatIni.Id);
                cmdJual.Parameters.AddWithValue("@pelanggan",
                    string.IsNullOrWhiteSpace(namaPelanggan) ? (object)DBNull.Value : namaPelanggan);
                cmdJual.Parameters.AddWithValue("@total", total);
                long idPenjualan = Convert.ToInt64(cmdJual.ExecuteScalar());

                // 2) simpan detail penjualan (1 baris item)
                var cmdDetail = new NpgsqlCommand(
                    "INSERT INTO detail_penjualan (id_penjualan, id_roasted, jumlah_gram, harga_per_gram, subtotal) " +
                    "VALUES (@jual,@roast,@qty,@harga,@subtotal)", koneksi, trx);
                cmdDetail.Parameters.AddWithValue("@jual", idPenjualan);
                cmdDetail.Parameters.AddWithValue("@roast", idRoast);
                cmdDetail.Parameters.AddWithValue("@qty", qtyGram);
                cmdDetail.Parameters.AddWithValue("@harga", hargaPerGram);
                cmdDetail.Parameters.AddWithValue("@subtotal", total);
                cmdDetail.ExecuteNonQuery();

                // 3) kurangi stok roast bean
                var cmdKurangi = new NpgsqlCommand(
                    "UPDATE biji_kopi_roasted SET stok_gram = stok_gram - @qty WHERE id_roasted=@id", koneksi, trx);
                cmdKurangi.Parameters.AddWithValue("@qty", qtyGram);
                cmdKurangi.Parameters.AddWithValue("@id", idRoast);
                cmdKurangi.ExecuteNonQuery();

                // 4) catat KELUAR ROASTED di riwayat stok
                var cmdRiwayat = new NpgsqlCommand(
                    "INSERT INTO riwayat_stok (arah,kategori,id_roasted,jumlah,satuan,referensi) " +
                    "VALUES ('KELUAR','ROASTED',@id,@qty,'gram',@ref)", koneksi, trx);
                cmdRiwayat.Parameters.AddWithValue("@id", idRoast);
                cmdRiwayat.Parameters.AddWithValue("@qty", qtyGram);
                cmdRiwayat.Parameters.AddWithValue("@ref", invoice);
                cmdRiwayat.ExecuteNonQuery();

                trx.Commit();   // semua sukses -> kunci
            }
            catch
            {
                trx.Rollback(); // ada yang gagal -> batalkan semua
                throw;
            }
        }
    }
}
