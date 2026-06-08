using Npgsql;
using SIKOPI_DOPY_ROASTERY.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIKOPI_DOPY_ROASTERY.Repositories
{
    public class RepositoriGreenBean : RepositoriDasar, IRepositoriGreenBean
    {
        // SELECT dasar + JOIN ke tabel lookup untuk ambil nama jenis/metode/grade (3NF)
        private const string SqlPilih =
            "SELECT g.*, bt.name AS jenis_nama, pm.name AS metode_nama, gr.name AS grade_nama " +
            "FROM green_beans g " +
            "LEFT JOIN bean_types bt      ON bt.id = g.bean_type_id " +
            "LEFT JOIN process_methods pm ON pm.id = g.process_method_id " +
            "LEFT JOIN grades gr          ON gr.id = g.grade_id";

        public List<GreenBean> DapatkanSemua()
        {
            var daftar = new List<GreenBean>();
            using var koneksi = BukaKoneksi();
            using var perintah = new NpgsqlCommand(SqlPilih + " ORDER BY g.id", koneksi);
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
            using var perintah = new NpgsqlCommand(SqlPilih + " WHERE g.id=@id", koneksi);
            perintah.Parameters.AddWithValue("@id", id);
            using var baca = perintah.ExecuteReader();
            if (!baca.Read()) return null;
            return BacaGreen(baca);
        }

        public long Tambah(GreenBean green)
        {
            using var koneksi = BukaKoneksi();
            using var perintah = new NpgsqlCommand(
                "INSERT INTO green_beans (name, origin, bean_type_id, process_method_id, grade_id, stock_kg, price_per_kg) " +
                "VALUES (@nama,@asal,@jenis,@metode,@grade,@stok,@harga) RETURNING id", koneksi);
            perintah.Parameters.AddWithValue("@nama", green.Nama);
            perintah.Parameters.AddWithValue("@asal", (object)green.Asal ?? DBNull.Value);
            perintah.Parameters.AddWithValue("@jenis", green.IdJenis);
            perintah.Parameters.AddWithValue("@metode", (object)green.IdMetode ?? DBNull.Value);
            perintah.Parameters.AddWithValue("@grade", (object)green.IdGrade ?? DBNull.Value);
            perintah.Parameters.AddWithValue("@stok", green.StokKg);
            perintah.Parameters.AddWithValue("@harga", green.HargaPerKg);
            return Convert.ToInt64(perintah.ExecuteScalar());
        }

        public void Ubah(GreenBean green)
        {
            using var koneksi = BukaKoneksi();
            using var perintah = new NpgsqlCommand(
                "UPDATE green_beans SET name=@nama, origin=@asal, bean_type_id=@jenis, " +
                "process_method_id=@metode, grade_id=@grade, stock_kg=@stok, price_per_kg=@harga WHERE id=@id", koneksi);
            perintah.Parameters.AddWithValue("@nama", green.Nama);
            perintah.Parameters.AddWithValue("@asal", (object)green.Asal ?? DBNull.Value);
            perintah.Parameters.AddWithValue("@jenis", green.IdJenis);
            perintah.Parameters.AddWithValue("@metode", (object)green.IdMetode ?? DBNull.Value);
            perintah.Parameters.AddWithValue("@grade", (object)green.IdGrade ?? DBNull.Value);
            perintah.Parameters.AddWithValue("@stok", green.StokKg);
            perintah.Parameters.AddWithValue("@harga", green.HargaPerKg);
            perintah.Parameters.AddWithValue("@id", green.Id);
            perintah.ExecuteNonQuery();
        }

        public void Hapus(long id)
        {
            using var koneksi = BukaKoneksi();
            using var perintah = new NpgsqlCommand("DELETE FROM green_beans WHERE id=@id", koneksi);
            perintah.Parameters.AddWithValue("@id", id);
            perintah.ExecuteNonQuery();
        }

        // Method tambahan (di luar interface): catat stok IN GREEN saat green bean baru ditambah
        public void CatatGerakMasukGreen(long idGreen, decimal jumlahKg, string referensi)
        {
            using var koneksi = BukaKoneksi();
            using var perintah = new NpgsqlCommand(
                "INSERT INTO stock_movements (direction, category, green_bean_id, qty, unit, reference) " +
                "VALUES ('IN','GREEN',@id,@jumlah,'Kg',@ref)", koneksi);
            perintah.Parameters.AddWithValue("@id", idGreen);
            perintah.Parameters.AddWithValue("@jumlah", jumlahKg);
            perintah.Parameters.AddWithValue("@ref", referensi);
            perintah.ExecuteNonQuery();
        }

        // method kecil untuk baca 1 baris jadi object (baca kolom Inggris + nama lookup hasil JOIN)
        private GreenBean BacaGreen(NpgsqlDataReader baca)
        {
            var green = new GreenBean();
            green.Id = Convert.ToInt64(baca["id"]);
            green.Nama = baca["name"].ToString();
            green.Asal = Convert.IsDBNull(baca["origin"]) ? "" : baca["origin"].ToString();
            green.IdJenis = Convert.ToInt64(baca["bean_type_id"]);
            green.IdMetode = Convert.IsDBNull(baca["process_method_id"]) ? (long?)null : Convert.ToInt64(baca["process_method_id"]);
            green.IdGrade = Convert.IsDBNull(baca["grade_id"]) ? (long?)null : Convert.ToInt64(baca["grade_id"]);
            green.NamaJenis = baca["jenis_nama"].ToString();
            green.NamaMetode = Convert.IsDBNull(baca["metode_nama"]) ? "" : baca["metode_nama"].ToString();
            green.NamaGrade = Convert.IsDBNull(baca["grade_nama"]) ? "" : baca["grade_nama"].ToString();
            green.StokKg = Convert.ToDecimal(baca["stock_kg"]);
            green.HargaPerKg = Convert.ToDecimal(baca["price_per_kg"]);
            return green;
        }
    }
}
