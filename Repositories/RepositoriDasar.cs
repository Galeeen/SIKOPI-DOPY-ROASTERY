using Npgsql;
using SIKOPI_DOPY_ROASTERY.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIKOPI_DOPY_ROASTERY.Repositories
{
    // ABSTRACT: berisi kode yang dipakai bersama semua repo (buka koneksi).
    // Tidak di-new langsung; hanya diwarisi. Ini contoh Inheritance untuk Reusability.
    public abstract class RepositoriDasar
    {
        protected NpgsqlConnection BukaKoneksi()
        {
            var koneksi = new NpgsqlConnection(KoneksiDb.ConnStr);
            koneksi.Open();
            return koneksi;
        }
    }
}
