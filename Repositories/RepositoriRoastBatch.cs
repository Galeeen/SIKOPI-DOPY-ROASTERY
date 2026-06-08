using Npgsql;
using SIKOPI_DOPY_ROASTERY.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIKOPI_DOPY_ROASTERY.Repositories
{
    public class RepositoriRoastBatch : RepositoriDasar, IRepositoriRoastBatch
    {
        // 3NF: JOIN ke roast_levels untuk ambil nama roast level
        private const string SqlPilih =
            "SELECT b.*, rl.name AS roast_level_nama " +
            "FROM roast_batches b " +
            "LEFT JOIN roast_levels rl ON rl.id = b.roast_level_id";

        public List<RoastBatch> DapatkanSemua()
        {
            var daftar = new List<RoastBatch>();
            using var koneksi = BukaKoneksi();
            using var perintah = new NpgsqlCommand(SqlPilih + " ORDER BY b.id DESC", koneksi);
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
            using var perintah = new NpgsqlCommand(SqlPilih + " WHERE b.id=@id", koneksi);
            perintah.Parameters.AddWithValue("@id", id);
            using var baca = perintah.ExecuteReader();
            if (!baca.Read()) return null;
            return BacaBatch(baca);
        }

        public long Tambah(RoastBatch batch)
        {
            using var koneksi = BukaKoneksi();
            using var perintah = new NpgsqlCommand(
                "INSERT INTO roast_batches (batch_code, green_bean_id, operator_user_id, green_used_kg, roast_result_g, roast_level_id, batch_date) " +
                "VALUES (@kode,@green,@operator,@dipakai,@hasil,@level,@tanggal) RETURNING id", koneksi);
            perintah.Parameters.AddWithValue("@kode", batch.KodeBatch);
            perintah.Parameters.AddWithValue("@green", batch.IdGreenBean);
            perintah.Parameters.AddWithValue("@operator", batch.IdOperator);
            perintah.Parameters.AddWithValue("@dipakai", batch.GreenDipakaiKg);
            perintah.Parameters.AddWithValue("@hasil", batch.HasilGram);
            perintah.Parameters.AddWithValue("@level", batch.IdTingkatRoasting);   // 3NF: simpan id, bukan teks
            perintah.Parameters.AddWithValue("@tanggal", batch.TanggalBatch);
            return Convert.ToInt64(perintah.ExecuteScalar());
        }

        private RoastBatch BacaBatch(NpgsqlDataReader baca)
        {
            var batch = new RoastBatch();
            batch.Id = Convert.ToInt64(baca["id"]);
            batch.KodeBatch = baca["batch_code"].ToString();
            batch.IdGreenBean = Convert.ToInt64(baca["green_bean_id"]);
            batch.IdOperator = Convert.IsDBNull(baca["operator_user_id"]) ? 0 : Convert.ToInt64(baca["operator_user_id"]);
            batch.GreenDipakaiKg = Convert.ToDecimal(baca["green_used_kg"]);
            batch.HasilGram = Convert.ToDecimal(baca["roast_result_g"]);
            batch.IdTingkatRoasting = Convert.ToInt64(baca["roast_level_id"]);
            batch.RoastLevel = Convert.IsDBNull(baca["roast_level_nama"]) ? "" : baca["roast_level_nama"].ToString();
            batch.TanggalBatch = Convert.ToDateTime(baca["batch_date"]);
            return batch;
        }
    }
}
