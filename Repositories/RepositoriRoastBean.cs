using Npgsql;
using SIKOPI_DOPY_ROASTERY.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIKOPI_DOPY_ROASTERY.Repositories
{
    public class RepositoriRoastBean : RepositoriDasar, IRepositoriRoastBean
    {
        // 3NF: roast level TIDAK ada di roast_beans — ambil lewat JOIN ke batch lalu ke roast_levels
        private const string SqlPilih =
            "SELECT rb.*, rl.name AS roast_level_nama " +
            "FROM roast_beans rb " +
            "LEFT JOIN roast_batches bt ON bt.id = rb.batch_id " +
            "LEFT JOIN roast_levels rl  ON rl.id = bt.roast_level_id";

        public List<RoastBean> DapatkanSemua()
        {
            var daftar = new List<RoastBean>();
            using var koneksi = BukaKoneksi();
            using var perintah = new NpgsqlCommand(SqlPilih + " ORDER BY rb.id", koneksi);
            using var baca = perintah.ExecuteReader();
            while (baca.Read())
            {
                daftar.Add(BacaRoast(baca));
            }
            return daftar;
        }

        public RoastBean DapatkanById(long id)
        {
            using var koneksi = BukaKoneksi();
            using var perintah = new NpgsqlCommand(SqlPilih + " WHERE rb.id=@id", koneksi);
            perintah.Parameters.AddWithValue("@id", id);
            using var baca = perintah.ExecuteReader();
            if (!baca.Read()) return null;
            return BacaRoast(baca);
        }

        public long Tambah(RoastBean roast)
        {
            // roast_beans TIDAK punya kolom roast level (diturunkan dari batch)
            using var koneksi = BukaKoneksi();
            using var perintah = new NpgsqlCommand(
                "INSERT INTO roast_beans (batch_id, name, stock_g, price_per_g) " +
                "VALUES (@batch,@nama,@stok,@harga) RETURNING id", koneksi);
            perintah.Parameters.AddWithValue("@batch", roast.IdBatch);
            perintah.Parameters.AddWithValue("@nama", roast.Nama);
            perintah.Parameters.AddWithValue("@stok", roast.StokGram);
            perintah.Parameters.AddWithValue("@harga", roast.HargaPerGram);
            return Convert.ToInt64(perintah.ExecuteScalar());
        }

        public void Ubah(RoastBean roast)
        {
            using var koneksi = BukaKoneksi();
            using var perintah = new NpgsqlCommand(
                "UPDATE roast_beans SET name=@nama, stock_g=@stok, price_per_g=@harga WHERE id=@id", koneksi);
            perintah.Parameters.AddWithValue("@nama", roast.Nama);
            perintah.Parameters.AddWithValue("@stok", roast.StokGram);
            perintah.Parameters.AddWithValue("@harga", roast.HargaPerGram);
            perintah.Parameters.AddWithValue("@id", roast.Id);
            perintah.ExecuteNonQuery();
        }

        public void Hapus(long id)
        {
            using var koneksi = BukaKoneksi();
            using var perintah = new NpgsqlCommand("DELETE FROM roast_beans WHERE id=@id", koneksi);
            perintah.Parameters.AddWithValue("@id", id);
            perintah.ExecuteNonQuery();
        }

        // Method tambahan: admin set harga jual per gram
        public void SetHarga(long idRoast, decimal hargaPerGram)
        {
            using var koneksi = BukaKoneksi();
            using var perintah = new NpgsqlCommand(
                "UPDATE roast_beans SET price_per_g=@harga WHERE id=@id", koneksi);
            perintah.Parameters.AddWithValue("@harga", hargaPerGram);
            perintah.Parameters.AddWithValue("@id", idRoast);
            perintah.ExecuteNonQuery();
        }

        private RoastBean BacaRoast(NpgsqlDataReader baca)
        {
            var roast = new RoastBean();
            roast.Id = Convert.ToInt64(baca["id"]);
            roast.IdBatch = Convert.IsDBNull(baca["batch_id"]) ? 0 : Convert.ToInt64(baca["batch_id"]);
            roast.Nama = baca["name"].ToString();
            roast.RoastLevel = Convert.IsDBNull(baca["roast_level_nama"]) ? "" : baca["roast_level_nama"].ToString();
            roast.StokGram = Convert.ToDecimal(baca["stock_g"]);
            roast.HargaPerGram = Convert.ToDecimal(baca["price_per_g"]);
            return roast;
        }
    }
}
