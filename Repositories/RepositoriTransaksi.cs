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
            using var perintah = new NpgsqlCommand("SELECT * FROM transactions ORDER BY id DESC", koneksi);
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
            using var perintah = new NpgsqlCommand("SELECT * FROM transactions WHERE id=@id", koneksi);
            perintah.Parameters.AddWithValue("@id", id);
            using var baca = perintah.ExecuteReader();
            if (!baca.Read()) return null;
            return BacaTransaksi(baca);
        }

        public long Tambah(Transaksi t)
        {
            using var koneksi = BukaKoneksi();
            using var perintah = new NpgsqlCommand(
                "INSERT INTO transactions (invoice, cashier_user_id, customer, total) " +
                "VALUES (@invoice,@kasir,@pelanggan,@total) RETURNING id", koneksi);
            perintah.Parameters.AddWithValue("@invoice", t.Invoice);
            perintah.Parameters.AddWithValue("@kasir", t.IdKasir);
            perintah.Parameters.AddWithValue("@pelanggan", t.NamaPelanggan);
            perintah.Parameters.AddWithValue("@total", t.Total);
            return Convert.ToInt64(perintah.ExecuteScalar());
        }

        private Transaksi BacaTransaksi(NpgsqlDataReader baca)
        {
            var t = new Transaksi();
            t.Id = Convert.ToInt64(baca["id"]);
            t.Invoice = baca["invoice"].ToString();
            t.IdKasir = Convert.IsDBNull(baca["cashier_user_id"]) ? 0 : Convert.ToInt64(baca["cashier_user_id"]);
            t.NamaPelanggan = Convert.IsDBNull(baca["customer"]) ? "" : baca["customer"].ToString();
            t.Total = Convert.ToDecimal(baca["total"]);
            t.TanggalTransaksi = Convert.ToDateTime(baca["tx_date"]);
            return t;
        }
    }
}
