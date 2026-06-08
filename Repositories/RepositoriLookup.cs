using Npgsql;
using SIKOPI_DOPY_ROASTERY.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIKOPI_DOPY_ROASTERY.Repositories
{
    public class RepositoriLookup : RepositoriDasar, IRepositoriLookup
    {
        // method privat serbaguna: baca tabel lookup apa pun (id, name) jadi List<Lookup>.
        // Nama tabel HARD-CODED dari method publik di bawah (bukan dari input user) -> aman dari SQL injection.
        private List<Lookup> Ambil(string namaTabel)
        {
            var daftar = new List<Lookup>();
            using var koneksi = BukaKoneksi();
            using var perintah = new NpgsqlCommand($"SELECT id, name FROM {namaTabel} ORDER BY name", koneksi);
            using var baca = perintah.ExecuteReader();
            while (baca.Read())
            {
                daftar.Add(new Lookup
                {
                    Id = Convert.ToInt64(baca["id"]),
                    Nama = baca["name"].ToString()
                });
            }
            return daftar;
        }

        public List<Lookup> DapatkanJenisBean() => Ambil("bean_types");
        public List<Lookup> DapatkanMetodeProses() => Ambil("process_methods");
        public List<Lookup> DapatkanGrade() => Ambil("grades");
        public List<Lookup> DapatkanTingkatRoasting() => Ambil("roast_levels");
    }
}
