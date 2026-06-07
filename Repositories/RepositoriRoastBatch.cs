using Npgsql;
using SIKOPI_DOPY_ROASTERY.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIKOPI_DOPY_ROASTERY.Repositories
{
    public class RepositoriRoastBatch : RepositoriDasar, IRepositoriRoastBatch
    {
        public List<RoastBatch> DapatkanSemua()
        {
            var daftar = new List<RoastBatch>();
            using var koneksi = BukaKoneksi();
            using var perintah = new NpgsqlCommand("SELECT * FROM batch_roasting ORDER BY id_batch DESC", koneksi);
            using var baca = perintah.ExecuteReader();
            while (baca.Read())
            {
                daftar.Add(BacaBatch(baca));
            }
            return daftar;
        }

        public RoastBatch DapatkanById(long id)
        {
            using var koneksi = BukaKoneksi();
            using var perintah = new NpgsqlCommand("SELECT * FROM batch_roasting WHERE id_batch=@id", koneksi);
            perintah.Parameters.AddWithValue("@id", id);
            using var baca = perintah.ExecuteReader();
            if (!baca.Read()) return null;
            return BacaBatch(baca);
        }

        public long Tambah(RoastBatch batch)
        {
            using var koneksi = BukaKoneksi();
            using var perintah = new NpgsqlCommand(
                "INSERT INTO batch_roasting (kode_batch, id_biji_mentah, id_operator, jumlah_biji_dipakai_kg, hasil_roasting_gram, tingkat_roasting, tanggal_batch) " +
                "VALUES (@kode,@green,@operator,@dipakai,@hasil,@level,@tanggal) RETURNING id_batch", koneksi);
            perintah.Parameters.AddWithValue("@kode", batch.KodeBatch);
            perintah.Parameters.AddWithValue("@green", batch.IdGreenBean);
            perintah.Parameters.AddWithValue("@operator", batch.IdOperator);
            perintah.Parameters.AddWithValue("@dipakai", batch.GreenDipakaiKg);
            perintah.Parameters.AddWithValue("@hasil", batch.HasilGram);
            perintah.Parameters.AddWithValue("@level", batch.RoastLevel);
            perintah.Parameters.AddWithValue("@tanggal", batch.TanggalBatch);
            return Convert.ToInt64(perintah.ExecuteScalar());
        }

        private RoastBatch BacaBatch(NpgsqlDataReader baca)
        {
            var batch = new RoastBatch();
            batch.Id = Convert.ToInt64(baca["id_batch"]);
            batch.KodeBatch = baca["kode_batch"].ToString();
            batch.IdGreenBean = Convert.ToInt64(baca["id_biji_mentah"]);
            batch.IdOperator = Convert.ToInt64(baca["id_operator"]);
            batch.GreenDipakaiKg = Convert.ToDecimal(baca["jumlah_biji_dipakai_kg"]);
            batch.HasilGram = Convert.ToDecimal(baca["hasil_roasting_gram"]);
            batch.RoastLevel = baca["tingkat_roasting"].ToString();
            batch.TanggalBatch = Convert.ToDateTime(baca["tanggal_batch"]);
            return batch;
        }
    }
}
