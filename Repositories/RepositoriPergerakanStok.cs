using Npgsql;
using SIKOPI_DOPY_ROASTERY.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIKOPI_DOPY_ROASTERY.Repositories
{
    public class RepositoriPergerakanStok : RepositoriDasar, IRepositoriPergerakanStok
    {
        public List<PergerakanStok> DapatkanSemua()
        {
            var daftar = new List<PergerakanStok>();
            using var koneksi = BukaKoneksi();
            using var perintah = new NpgsqlCommand("SELECT * FROM riwayat_stok ORDER BY id_riwayat_stok DESC", koneksi);
            using var baca = perintah.ExecuteReader();
            while (baca.Read())
            {
                var gerak = new PergerakanStok();
                gerak.Id = Convert.ToInt64(baca["id_riwayat_stok"]);
                gerak.Arah = baca["arah"].ToString();
                gerak.Kategori = baca["kategori"].ToString();
                gerak.IdGreenBean = Convert.IsDBNull(baca["id_biji_mentah"]) ? (long?)null : Convert.ToInt64(baca["id_biji_mentah"]);
                gerak.IdRoastBean = Convert.IsDBNull(baca["id_roasted"]) ? (long?)null : Convert.ToInt64(baca["id_roasted"]);
                gerak.Jumlah = Convert.ToDecimal(baca["jumlah"]);
                gerak.Satuan = baca["satuan"].ToString();
                gerak.Referensi = Convert.IsDBNull(baca["referensi"]) ? "" : baca["referensi"].ToString();
                gerak.TanggalGerak = Convert.ToDateTime(baca["tanggal_riwayat"]);
                daftar.Add(gerak);
            }
            return daftar;
        }

        public long Tambah(PergerakanStok gerak)
        {
            using var koneksi = BukaKoneksi();
            using var perintah = new NpgsqlCommand(
                "INSERT INTO riwayat_stok (arah, kategori, id_biji_mentah, id_roasted, jumlah, satuan, referensi) " +
                "VALUES (@arah,@kategori,@green,@roast,@jumlah,@satuan,@ref) RETURNING id_riwayat_stok", koneksi);
            perintah.Parameters.AddWithValue("@arah", gerak.Arah);
            perintah.Parameters.AddWithValue("@kategori", gerak.Kategori);
            // kalau kosong (null), kirim DBNull.Value ke database
            if (gerak.IdGreenBean == null)
                perintah.Parameters.AddWithValue("@green", DBNull.Value);
            else
                perintah.Parameters.AddWithValue("@green", gerak.IdGreenBean);
            if (gerak.IdRoastBean == null)
                perintah.Parameters.AddWithValue("@roast", DBNull.Value);
            else
                perintah.Parameters.AddWithValue("@roast", gerak.IdRoastBean);
            perintah.Parameters.AddWithValue("@jumlah", gerak.Jumlah);
            perintah.Parameters.AddWithValue("@satuan", gerak.Satuan);
            perintah.Parameters.AddWithValue("@ref", gerak.Referensi);
            return Convert.ToInt64(perintah.ExecuteScalar());
        }
    }
}
