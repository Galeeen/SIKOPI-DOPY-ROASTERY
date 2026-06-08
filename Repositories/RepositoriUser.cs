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
                using var perintah = new NpgsqlCommand("SELECT * FROM users ORDER BY id", koneksi);
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
                using var perintah = new NpgsqlCommand("SELECT * FROM users WHERE id=@id", koneksi);
                perintah.Parameters.AddWithValue("@id", id);
                using var baca = perintah.ExecuteReader();
                if (!baca.Read()) return null;
                return BacaUser(baca);
            }

            // dipakai AuthController saat login (cari user berdasarkan username)
            public User DapatkanByUsername(string username)
            {
                using var koneksi = BukaKoneksi();
                using var perintah = new NpgsqlCommand("SELECT * FROM users WHERE username=@username", koneksi);
                perintah.Parameters.AddWithValue("@username", username);
                using var baca = perintah.ExecuteReader();
                if (!baca.Read()) return null;
                return BacaUser(baca);
            }

            public long Tambah(User user)
            {
                using var koneksi = BukaKoneksi();
                using var perintah = new NpgsqlCommand(
                    "INSERT INTO users (username, password_hash, name, role) " +
                    "VALUES (@username,@password,@nama,@peran) RETURNING id", koneksi);
                perintah.Parameters.AddWithValue("@username", user.Username);
                perintah.Parameters.AddWithValue("@password", user.Password);  // plaintext (tanpa hash, sesuai materi)
                perintah.Parameters.AddWithValue("@nama", user.Nama);
                perintah.Parameters.AddWithValue("@peran", user.Peran);
                return Convert.ToInt64(perintah.ExecuteScalar());
            }

            public void Ubah(User user)
            {
                using var koneksi = BukaKoneksi();
                using var perintah = new NpgsqlCommand(
                    "UPDATE users SET username=@username, password_hash=@password, name=@nama, role=@peran WHERE id=@id", koneksi);
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
                using var perintah = new NpgsqlCommand("DELETE FROM users WHERE id=@id", koneksi);
                perintah.Parameters.AddWithValue("@id", id);
                perintah.ExecuteNonQuery();
            }

            private User BacaUser(NpgsqlDataReader baca)
            {
                var user = new User();
                user.Id = Convert.ToInt64(baca["id"]);
                user.Username = baca["username"].ToString();
                user.Password = baca["password_hash"].ToString();
                user.Nama = baca["name"].ToString();
                user.Peran = baca["role"].ToString();
                return user;
            }
    }
}
