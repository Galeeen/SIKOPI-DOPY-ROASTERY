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

            // 3NF: kolom customer NOT NULL -> kalau kosong, pakai default "Umum"
            string pelanggan = string.IsNullOrWhiteSpace(namaPelanggan) ? "Umum" : namaPelanggan.Trim();

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
                    "INSERT INTO transactions (invoice, cashier_user_id, customer, total) " +
                    "VALUES (@inv,@kasir,@pelanggan,@total) RETURNING id", koneksi, trx);
                cmdJual.Parameters.AddWithValue("@inv", invoice);
                cmdJual.Parameters.AddWithValue("@kasir", SesiAktif.PenggunaSaatIni.Id);
                cmdJual.Parameters.AddWithValue("@pelanggan", pelanggan);
                cmdJual.Parameters.AddWithValue("@total", total);
                long idPenjualan = Convert.ToInt64(cmdJual.ExecuteScalar());

                // 2) simpan detail penjualan (1 baris item)
                var cmdDetail = new NpgsqlCommand(
                    "INSERT INTO transaction_items (transaction_id, roast_bean_id, qty_g, price_per_g, subtotal) " +
                    "VALUES (@jual,@roast,@qty,@harga,@subtotal)", koneksi, trx);
                cmdDetail.Parameters.AddWithValue("@jual", idPenjualan);
                cmdDetail.Parameters.AddWithValue("@roast", idRoast);
                cmdDetail.Parameters.AddWithValue("@qty", qtyGram);
                cmdDetail.Parameters.AddWithValue("@harga", hargaPerGram);
                cmdDetail.Parameters.AddWithValue("@subtotal", total);
                cmdDetail.ExecuteNonQuery();

                // 3) kurangi stok roast bean
                var cmdKurangi = new NpgsqlCommand(
                    "UPDATE roast_beans SET stock_g = stock_g - @qty WHERE id=@id", koneksi, trx);
                cmdKurangi.Parameters.AddWithValue("@qty", qtyGram);
                cmdKurangi.Parameters.AddWithValue("@id", idRoast);
                cmdKurangi.ExecuteNonQuery();

                // 4) catat OUT ROAST di pergerakan stok
                var cmdRiwayat = new NpgsqlCommand(
                    "INSERT INTO stock_movements (direction,category,roast_bean_id,qty,unit,reference) " +
                    "VALUES ('OUT','ROAST',@id,@qty,'g',@ref)", koneksi, trx);
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
