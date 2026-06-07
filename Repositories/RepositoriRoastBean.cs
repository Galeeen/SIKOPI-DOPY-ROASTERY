using Npgsql;
using SIKOPI_DOPY_ROASTERY.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIKOPI_DOPY_ROASTERY.Repositories
{
    public class RepositoriRoastBean : RepositoriDasar, IRepositoriRoastBean
    {
        public List<RoastBean> DapatkanSemua()
        {
            var daftar = new List<RoastBean>();
            using var koneksi = BukaKoneksi();
            using var perintah = new NpgsqlCommand("SELECT * FROM biji_kopi_roasted ORDER BY id_roasted", koneksi);
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
            using var perintah = new NpgsqlCommand("SELECT * FROM biji_kopi_roasted WHERE id_roasted=@id", koneksi);
            perintah.Parameters.AddWithValue("@id", id);
            using var baca = perintah.ExecuteReader();
            if (!baca.Read()) return null;
            return BacaRoast(baca);
        }

        public long Tambah(RoastBean roast)
        {
            using var koneksi = BukaKoneksi();
            using var perintah = new NpgsqlCommand(
                "INSERT INTO biji_kopi_roasted (id_batch, nama_produk, tingkat_roasting, stok_gram, harga_per_gram) " +
                "VALUES (@batch,@nama,@level,@stok,@harga) RETURNING id_roasted", koneksi);
            perintah.Parameters.AddWithValue("@batch", roast.IdBatch);
            perintah.Parameters.AddWithValue("@nama", roast.Nama);
            perintah.Parameters.AddWithValue("@level", roast.RoastLevel);
            perintah.Parameters.AddWithValue("@stok", roast.StokGram);
            perintah.Parameters.AddWithValue("@harga", roast.HargaPerGram);
            return Convert.ToInt64(perintah.ExecuteScalar());
        }

        public void Ubah(RoastBean roast)
        {
            using var koneksi = BukaKoneksi();
            using var perintah = new NpgsqlCommand(
                "UPDATE biji_kopi_roasted SET nama_produk=@nama, tingkat_roasting=@level, stok_gram=@stok, harga_per_gram=@harga WHERE id_roasted=@id", koneksi);
            perintah.Parameters.AddWithValue("@nama", roast.Nama);
            perintah.Parameters.AddWithValue("@level", roast.RoastLevel);
            perintah.Parameters.AddWithValue("@stok", roast.StokGram);
            perintah.Parameters.AddWithValue("@harga", roast.HargaPerGram);
            perintah.Parameters.AddWithValue("@id", roast.Id);
            perintah.ExecuteNonQuery();
        }

        public void Hapus(long id)
        {
            using var koneksi = BukaKoneksi();
            using var perintah = new NpgsqlCommand("DELETE FROM biji_kopi_roasted WHERE id_roasted=@id", koneksi);
            perintah.Parameters.AddWithValue("@id", id);
            perintah.ExecuteNonQuery();
        }

        // Method tambahan: admin set harga jual per gram
        public void SetHarga(long idRoast, decimal hargaPerGram)
        {
            using var koneksi = BukaKoneksi();
            using var perintah = new NpgsqlCommand(
                "UPDATE biji_kopi_roasted SET harga_per_gram=@harga WHERE id_roasted=@id", koneksi);
            perintah.Parameters.AddWithValue("@harga", hargaPerGram);
            perintah.Parameters.AddWithValue("@id", idRoast);
            perintah.ExecuteNonQuery();
        }

        private RoastBean BacaRoast(NpgsqlDataReader baca)
        {
            var roast = new RoastBean();
            roast.Id = Convert.ToInt64(baca["id_roasted"]);
            roast.IdBatch = Convert.IsDBNull(baca["id_batch"]) ? 0 : Convert.ToInt64(baca["id_batch"]);
            roast.Nama = baca["nama_produk"].ToString();
            roast.RoastLevel = baca["tingkat_roasting"].ToString();
            roast.StokGram = Convert.ToDecimal(baca["stok_gram"]);
            roast.HargaPerGram = Convert.ToDecimal(baca["harga_per_gram"]);
            return roast;
        }
    }
}
