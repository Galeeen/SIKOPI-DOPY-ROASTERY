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
                                decimal hasilGram, string level, DateTime tanggal)
        {
            var green = _repoGreen.DapatkanById(idGreen);
            if (green == null) throw new ArgumentException("Green bean tidak ditemukan");
            if (greenDipakaiKg <= 0) throw new ArgumentException("Berat dipakai harus > 0");
            if (greenDipakaiKg > green.StokKg) throw new ArgumentException("Stok green tidak cukup");
            if (hasilGram >= greenDipakaiKg * 1000) throw new ArgumentException("Hasil harus menyusut (lossy)");

            // Semua langkah harus berhasil bersama, atau dibatalkan semua -> pakai TRANSACTION
            using var koneksi = new NpgsqlConnection(KoneksiDb.ConnStr);
            koneksi.Open();
            using var trx = koneksi.BeginTransaction();
            try
            {
                // 1) simpan header batch
                var cmdBatch = new NpgsqlCommand(
                    "INSERT INTO batch_roasting (kode_batch, id_biji_mentah, id_operator, " +
                    "jumlah_biji_dipakai_kg, hasil_roasting_gram, tingkat_roasting, tanggal_batch) " +
                    "VALUES (@kode,@gid,@op,@dipakai,@hasil,@level,@tgl) RETURNING id_batch", koneksi, trx);
                cmdBatch.Parameters.AddWithValue("@kode", kodeBatch);
                cmdBatch.Parameters.AddWithValue("@gid", idGreen);
                cmdBatch.Parameters.AddWithValue("@op", SesiAktif.PenggunaSaatIni.Id);
                cmdBatch.Parameters.AddWithValue("@dipakai", greenDipakaiKg);
                cmdBatch.Parameters.AddWithValue("@hasil", hasilGram);
                cmdBatch.Parameters.AddWithValue("@level", level);
                cmdBatch.Parameters.AddWithValue("@tgl", tanggal);
                long idBatch = Convert.ToInt64(cmdBatch.ExecuteScalar());

                // 2) kurangi stok green
                var cmdKurangiGreen = new NpgsqlCommand(
                    "UPDATE biji_kopi_mentah SET stok_kg = stok_kg - @dipakai WHERE id_biji_mentah=@id", koneksi, trx);
                cmdKurangiGreen.Parameters.AddWithValue("@dipakai", greenDipakaiKg);
                cmdKurangiGreen.Parameters.AddWithValue("@id", idGreen);
                cmdKurangiGreen.ExecuteNonQuery();

                // 3) buat SKU roast bean baru (harga 0)
                var cmdRoast = new NpgsqlCommand(
                    "INSERT INTO biji_kopi_roasted (id_batch, nama_produk, tingkat_roasting, stok_gram, harga_per_gram) " +
                    "VALUES (@bid,@nama,@level,@stok,0) RETURNING id_roasted", koneksi, trx);
                cmdRoast.Parameters.AddWithValue("@bid", idBatch);
                cmdRoast.Parameters.AddWithValue("@nama", $"{green.Nama} - {level}");
                cmdRoast.Parameters.AddWithValue("@level", level);
                cmdRoast.Parameters.AddWithValue("@stok", hasilGram);
                long idRoast = Convert.ToInt64(cmdRoast.ExecuteScalar());

                // 4) catat OUT GREEN
                var cmdOutGreen = new NpgsqlCommand(
                    "INSERT INTO riwayat_stok (arah,kategori,id_biji_mentah,jumlah,satuan,referensi) " +
                    "VALUES ('KELUAR','MENTAH',@id,@jumlah,'kg',@ref)", koneksi, trx);
                cmdOutGreen.Parameters.AddWithValue("@id", idGreen);
                cmdOutGreen.Parameters.AddWithValue("@jumlah", greenDipakaiKg);
                cmdOutGreen.Parameters.AddWithValue("@ref", kodeBatch);
                cmdOutGreen.ExecuteNonQuery();

                // 5) catat IN ROAST
                var cmdInRoast = new NpgsqlCommand(
                    "INSERT INTO riwayat_stok (arah,kategori,id_roasted,jumlah,satuan,referensi) " +
                    "VALUES ('MASUK','ROASTED',@id,@jumlah,'gram',@ref)", koneksi, trx);
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
