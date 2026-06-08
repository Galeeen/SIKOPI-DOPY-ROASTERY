using Npgsql;
using SIKOPI_DOPY_ROASTERY.Data;
using SIKOPI_DOPY_ROASTERY.Helpers;
using SIKOPI_DOPY_ROASTERY.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIKOPI_DOPY_ROASTERY.Controllers
{
    public class RoastingController
    {
        private readonly RepositoriGreenBean _repoGreen;
        public RoastingController(RepositoriGreenBean repoGreen) { _repoGreen = repoGreen; }

        public void TambahBatch(long idGreen, string kodeBatch, decimal greenDipakaiKg,
                                decimal hasilGram, long idLevel, DateTime tanggal)
        {
            var green = _repoGreen.DapatkanById(idGreen);
            if (green == null) throw new ArgumentException("Green bean tidak ditemukan");
            if (idLevel <= 0) throw new ArgumentException("Tingkat roasting wajib dipilih");
            if (greenDipakaiKg <= 0) throw new ArgumentException("Berat dipakai harus > 0");
            if (greenDipakaiKg > green.StokKg) throw new ArgumentException("Stok green tidak cukup");
            if (hasilGram >= greenDipakaiKg * 1000) throw new ArgumentException("Hasil harus menyusut (lossy)");

            // Semua langkah harus berhasil bersama, atau dibatalkan semua -> pakai TRANSACTION
            using var koneksi = new NpgsqlConnection(KoneksiDb.ConnStr);
            koneksi.Open();
            using var trx = koneksi.BeginTransaction();
            try
            {
                // 1) simpan header batch (roast level disimpan sebagai FK: roast_level_id)
                var cmdBatch = new NpgsqlCommand(
                    "INSERT INTO roast_batches (batch_code, green_bean_id, operator_user_id, " +
                    "green_used_kg, roast_result_g, roast_level_id, batch_date) " +
                    "VALUES (@kode,@gid,@op,@dipakai,@hasil,@level,@tgl) RETURNING id", koneksi, trx);
                cmdBatch.Parameters.AddWithValue("@kode", kodeBatch);
                cmdBatch.Parameters.AddWithValue("@gid", idGreen);
                cmdBatch.Parameters.AddWithValue("@op", SesiAktif.PenggunaSaatIni.Id);
                cmdBatch.Parameters.AddWithValue("@dipakai", greenDipakaiKg);
                cmdBatch.Parameters.AddWithValue("@hasil", hasilGram);
                cmdBatch.Parameters.AddWithValue("@level", idLevel);   // 3NF: simpan id (FK), bukan teks
                cmdBatch.Parameters.AddWithValue("@tgl", tanggal);
                long idBatch = Convert.ToInt64(cmdBatch.ExecuteScalar());

                // 2) kurangi stok green
                var cmdKurangiGreen = new NpgsqlCommand(
                    "UPDATE green_beans SET stock_kg = stock_kg - @dipakai WHERE id=@id", koneksi, trx);
                cmdKurangiGreen.Parameters.AddWithValue("@dipakai", greenDipakaiKg);
                cmdKurangiGreen.Parameters.AddWithValue("@id", idGreen);
                cmdKurangiGreen.ExecuteNonQuery();

                // 3) buat SKU roast bean baru (harga 0). Roast level TIDAK disimpan di sini (diturunkan dari batch via JOIN).
                var cmdRoast = new NpgsqlCommand(
                    "INSERT INTO roast_beans (batch_id, name, stock_g, price_per_g) " +
                    "VALUES (@bid,@nama,@stok,0) RETURNING id", koneksi, trx);
                cmdRoast.Parameters.AddWithValue("@bid", idBatch);
                cmdRoast.Parameters.AddWithValue("@nama", $"{green.Nama} (Batch {kodeBatch})");
                cmdRoast.Parameters.AddWithValue("@stok", hasilGram);
                long idRoast = Convert.ToInt64(cmdRoast.ExecuteScalar());

                // 4) catat OUT GREEN
                var cmdOutGreen = new NpgsqlCommand(
                    "INSERT INTO stock_movements (direction,category,green_bean_id,qty,unit,reference) " +
                    "VALUES ('OUT','GREEN',@id,@jumlah,'Kg',@ref)", koneksi, trx);
                cmdOutGreen.Parameters.AddWithValue("@id", idGreen);
                cmdOutGreen.Parameters.AddWithValue("@jumlah", greenDipakaiKg);
                cmdOutGreen.Parameters.AddWithValue("@ref", kodeBatch);
                cmdOutGreen.ExecuteNonQuery();

                // 5) catat IN ROAST
                var cmdInRoast = new NpgsqlCommand(
                    "INSERT INTO stock_movements (direction,category,roast_bean_id,qty,unit,reference) " +
                    "VALUES ('IN','ROAST',@id,@jumlah,'g',@ref)", koneksi, trx);
                cmdInRoast.Parameters.AddWithValue("@id", idRoast);
                cmdInRoast.Parameters.AddWithValue("@jumlah", hasilGram);
                cmdInRoast.Parameters.AddWithValue("@ref", kodeBatch);
                cmdInRoast.ExecuteNonQuery();

                trx.Commit();   // semua sukses -> kunci
            }
            catch
            {
                trx.Rollback(); // ada yang gagal -> batalkan semua
                throw;
            }
        }
    }
}
