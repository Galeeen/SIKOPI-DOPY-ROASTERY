using Npgsql;
using SIKOPI_DOPY_ROASTERY.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIKOPI_DOPY_ROASTERY.Repositories
{
    public class RepositoriTransaksi : RepositoriDasar, IRepositoriTransaksi
    {
        public List<Transaksi> DapatkanSemua()
        {
            var daftar = new List<Transaksi>();
            using var koneksi = BukaKoneksi();
            using var perintah = new NpgsqlCommand("SELECT * FROM penjualan ORDER BY id_penjualan DESC", koneksi);
            using var baca = perintah.ExecuteReader();
            while (baca.Read())
            {
                daftar.Add(BacaTransaksi(baca));
            }
            return daftar;
        }

        public Transaksi DapatkanById(long id)
        {
            using var koneksi = BukaKoneksi();
            using var perintah = new NpgsqlCommand("SELECT * FROM penjualan WHERE id_penjualan=@id", koneksi);
            perintah.Parameters.AddWithValue("@id", id);
            using var baca = perintah.ExecuteReader();
            if (!baca.Read()) return null;
            return BacaTransaksi(baca);
        }

        public long Tambah(Transaksi t)
        {
            using var koneksi = BukaKoneksi();
            using var perintah = new NpgsqlCommand(
                "INSERT INTO penjualan (nomor_invoice, id_karyawan_penjualan, nama_pelanggan, total_penjualan) " +
                "VALUES (@invoice,@kasir,@pelanggan,@total) RETURNING id_penjualan", koneksi);
            perintah.Parameters.AddWithValue("@invoice", t.Invoice);
            perintah.Parameters.AddWithValue("@kasir", t.IdKasir);
            perintah.Parameters.AddWithValue("@pelanggan", t.NamaPelanggan);
            perintah.Parameters.AddWithValue("@total", t.Total);
            return Convert.ToInt64(perintah.ExecuteScalar());
        }

        private Transaksi BacaTransaksi(NpgsqlDataReader baca)
        {
            var t = new Transaksi();
            t.Id = Convert.ToInt64(baca["id_penjualan"]);
            t.Invoice = baca["nomor_invoice"].ToString();
            t.IdKasir = Convert.ToInt64(baca["id_karyawan_penjualan"]);
            t.NamaPelanggan = Convert.IsDBNull(baca["nama_pelanggan"]) ? "" : baca["nama_pelanggan"].ToString();
            t.Total = Convert.ToDecimal(baca["total_penjualan"]);
            t.TanggalTransaksi = Convert.ToDateTime(baca["tanggal_penjualan"]);
            return t;
        }
    }
}
