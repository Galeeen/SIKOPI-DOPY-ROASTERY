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
            using var perintah = new NpgsqlCommand("SELECT * FROM stock_movements ORDER BY id DESC", koneksi);
            using var baca = perintah.ExecuteReader();
            while (baca.Read())
            {
                var gerak = new PergerakanStok();
                gerak.Id = Convert.ToInt64(baca["id"]);
                gerak.Arah = baca["direction"].ToString();
                gerak.Kategori = baca["category"].ToString();
                gerak.IdGreenBean = Convert.IsDBNull(baca["green_bean_id"]) ? (long?)null : Convert.ToInt64(baca["green_bean_id"]);
                gerak.IdRoastBean = Convert.IsDBNull(baca["roast_bean_id"]) ? (long?)null : Convert.ToInt64(baca["roast_bean_id"]);
                gerak.Jumlah = Convert.ToDecimal(baca["qty"]);
                gerak.Satuan = baca["unit"].ToString();
                gerak.Referensi = Convert.IsDBNull(baca["reference"]) ? "" : baca["reference"].ToString();
                gerak.TanggalGerak = Convert.ToDateTime(baca["movement_date"]);
                daftar.Add(gerak);
            }
            return daftar;
        }

        public long Tambah(PergerakanStok gerak)
        {
            using var koneksi = BukaKoneksi();
            using var perintah = new NpgsqlCommand(
                "INSERT INTO stock_movements (direction, category, green_bean_id, roast_bean_id, qty, unit, reference) " +
                "VALUES (@arah,@kategori,@green,@roast,@jumlah,@satuan,@ref) RETURNING id", koneksi);
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
