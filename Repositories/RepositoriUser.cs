using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;
using SIKOPI_DOPY_ROASTERY.Models;  // ← tambah ini

namespace SIKOPI_DOPY_ROASTERY.Repositories
{
    public class RepositoriUser : RepositoriDasar, IRepositoriUser
    {
        public List<User> DapatkanSemua()
        {
            var daftar = new List<User>();
            using var koneksi = BukaKoneksi();
            using var perintah = new NpgsqlCommand("SELECT * FROM pengguna ORDER BY id_pengguna", koneksi);
            using var baca = perintah.ExecuteReader();
            while (baca.Read())
            {
                daftar.Add(BacaUser(baca));
            }
            return daftar;
        }

        public User DapatkanById(long id)
        {
            using var koneksi = BukaKoneksi();
            using var perintah = new NpgsqlCommand("SELECT * FROM pengguna WHERE id_pengguna=@id", koneksi);
            perintah.Parameters.AddWithValue("@id", id);
            using var baca = perintah.ExecuteReader();
            if (!baca.Read()) return null;
            return BacaUser(baca);
        }

        // dipakai AuthController saat login (cari user berdasarkan nama_pengguna)
        public User DapatkanByUsername(string username)
        {
            using var koneksi = BukaKoneksi();
            using var perintah = new NpgsqlCommand("SELECT * FROM pengguna WHERE nama_pengguna=@username", koneksi);
            perintah.Parameters.AddWithValue("@username", username);
            using var baca = perintah.ExecuteReader();
            if (!baca.Read()) return null;
            return BacaUser(baca);
        }

        public long Tambah(User user)
        {
            using var koneksi = BukaKoneksi();
            using var perintah = new NpgsqlCommand(
                "INSERT INTO pengguna (nama_pengguna, kata_sandi_hash, nama_lengkap, peran) " +
                "VALUES (@username,@password,@nama,@peran) RETURNING id_pengguna", koneksi);
            perintah.Parameters.AddWithValue("@username", user.Username);
            perintah.Parameters.AddWithValue("@password", user.Password);
            perintah.Parameters.AddWithValue("@nama", user.Nama);
            perintah.Parameters.AddWithValue("@peran", user.Peran);
            return Convert.ToInt64(perintah.ExecuteScalar());
        }

        public void Ubah(User user)
        {
            using var koneksi = BukaKoneksi();
            using var perintah = new NpgsqlCommand(
                "UPDATE pengguna SET nama_pengguna=@username, kata_sandi_hash=@password, nama_lengkap=@nama, peran=@peran WHERE id_pengguna=@id", koneksi);
            perintah.Parameters.AddWithValue("@username", user.Username);
            perintah.Parameters.AddWithValue("@password", user.Password);
            perintah.Parameters.AddWithValue("@nama", user.Nama);
            perintah.Parameters.AddWithValue("@peran", user.Peran);
            perintah.Parameters.AddWithValue("@id", user.Id);
            perintah.ExecuteNonQuery();
        }

        public void Hapus(long id)
        {
            using var koneksi = BukaKoneksi();
            using var perintah = new NpgsqlCommand("DELETE FROM pengguna WHERE id_pengguna=@id", koneksi);
            perintah.Parameters.AddWithValue("@id", id);
            perintah.ExecuteNonQuery();
        }

        private User BacaUser(NpgsqlDataReader baca)
        {
            var user = new User();
            user.Id = Convert.ToInt64(baca["id_pengguna"]);
            user.Username = baca["nama_pengguna"].ToString();
            user.Password = baca["kata_sandi_hash"].ToString();
            user.Nama = baca["nama_lengkap"].ToString();
            user.Peran = baca["peran"].ToString();
            return user;
        }
    }
}
