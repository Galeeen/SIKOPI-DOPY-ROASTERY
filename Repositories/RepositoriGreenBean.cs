using Npgsql;
using SIKOPI_DOPY_ROASTERY.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIKOPI_DOPY_ROASTERY.Repositories
{
    public class RepositoriGreenBean : RepositoriDasar, IRepositoriGreenBean
    {
        public List<GreenBean> DapatkanSemua()
        {
            var daftar = new List<GreenBean>();
            using var koneksi = BukaKoneksi();
            using var perintah = new NpgsqlCommand("SELECT * FROM biji_kopi_mentah ORDER BY id_biji_mentah", koneksi);
            using var baca = perintah.ExecuteReader();
            while (baca.Read())
            {
                daftar.Add(BacaGreen(baca));
            }
            return daftar;
        }

        public GreenBean DapatkanById(long id)
        {
            using var koneksi = BukaKoneksi();
            using var perintah = new NpgsqlCommand("SELECT * FROM biji_kopi_mentah WHERE id_biji_mentah=@id", koneksi);
            perintah.Parameters.AddWithValue("@id", id);
            using var baca = perintah.ExecuteReader();
            if (!baca.Read()) return null;
            return BacaGreen(baca);
        }

        public long Tambah(GreenBean green)
        {
            using var koneksi = BukaKoneksi();
            using var perintah = new NpgsqlCommand(
                "INSERT INTO biji_kopi_mentah (nama_biji, asal, jenis, stok_kg, harga_per_kg) " +
                "VALUES (@nama,@asal,@tipe,@stok,@harga) RETURNING id_biji_mentah", koneksi);
            perintah.Parameters.AddWithValue("@nama", green.Nama);
            perintah.Parameters.AddWithValue("@asal", green.Asal);
            perintah.Parameters.AddWithValue("@tipe", green.Tipe);
            perintah.Parameters.AddWithValue("@stok", green.StokKg);
            perintah.Parameters.AddWithValue("@harga", green.HargaPerKg);
            return Convert.ToInt64(perintah.ExecuteScalar());
        }

        public void Ubah(GreenBean green)
        {
            using var koneksi = BukaKoneksi();
            using var perintah = new NpgsqlCommand(
                "UPDATE biji_kopi_mentah SET nama_biji=@nama, asal=@asal, jenis=@tipe, " +
                "stok_kg=@stok, harga_per_kg=@harga WHERE id_biji_mentah=@id", koneksi);
            perintah.Parameters.AddWithValue("@nama", green.Nama);
            perintah.Parameters.AddWithValue("@asal", green.Asal);
            perintah.Parameters.AddWithValue("@tipe", green.Tipe);
            perintah.Parameters.AddWithValue("@stok", green.StokKg);
            perintah.Parameters.AddWithValue("@harga", green.HargaPerKg);
            perintah.Parameters.AddWithValue("@id", green.Id);
            perintah.ExecuteNonQuery();
        }

        public void Hapus(long id)
        {
            using var koneksi = BukaKoneksi();
            using var perintah = new NpgsqlCommand("DELETE FROM biji_kopi_mentah WHERE id_biji_mentah=@id", koneksi);
            perintah.Parameters.AddWithValue("@id", id);
            perintah.ExecuteNonQuery();
        }

        // Method tambahan (di luar interface): catat stok MASUK saat green bean baru ditambah
        public void CatatGerakMasukGreen(long idGreen, decimal jumlahKg, string referensi)
        {
            using var koneksi = BukaKoneksi();
            using var perintah = new NpgsqlCommand(
                "INSERT INTO riwayat_stok (arah, kategori, id_biji_mentah, jumlah, satuan, referensi) " +
                "VALUES ('MASUK','MENTAH',@id,@jumlah,'kg',@ref)", koneksi);
            perintah.Parameters.AddWithValue("@id", idGreen);
            perintah.Parameters.AddWithValue("@jumlah", jumlahKg);
            perintah.Parameters.AddWithValue("@ref", referensi);
            perintah.ExecuteNonQuery();
        }

        // method kecil untuk baca 1 baris jadi object (biar tidak nulis berulang)
        private GreenBean BacaGreen(NpgsqlDataReader baca)
        {
            var green = new GreenBean();
            green.Id = Convert.ToInt64(baca["id_biji_mentah"]);
            green.Nama = baca["nama_biji"].ToString();
            green.Asal = baca["asal"].ToString();
            green.Tipe = baca["jenis"].ToString();
            green.StokKg = Convert.ToDecimal(baca["stok_kg"]);
            green.HargaPerKg = Convert.ToDecimal(baca["harga_per_kg"]);
            return green;
        }
    }
}
