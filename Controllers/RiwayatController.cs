using SIKOPI_DOPY_ROASTERY.Models;
using SIKOPI_DOPY_ROASTERY.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIKOPI_DOPY_ROASTERY.Controllers
{
    public class RiwayatController
    {
        private readonly RepositoriPergerakanStok _repoGerak;
        private readonly RepositoriTransaksi _repoTransaksi;

        public RiwayatController(RepositoriPergerakanStok repoGerak, RepositoriTransaksi repoTransaksi)
        {
            _repoGerak = repoGerak;
            _repoTransaksi = repoTransaksi;
        }

        // Semua pergerakan stok (tanpa filter)
        public List<PergerakanStok> DaftarPergerakan()
        {
            return _repoGerak.DapatkanSemua();
        }

        // Pergerakan stok dengan filter. Kirim null atau "SEMUA" untuk tidak menyaring.
        public List<PergerakanStok> DaftarPergerakanTersaring(string arah, string kategori)
        {
            var hasil = new List<PergerakanStok>();
            foreach (var g in _repoGerak.DapatkanSemua())
            {
                bool cocokArah = string.IsNullOrEmpty(arah) || arah == "SEMUA" || g.Arah == arah;
                bool cocokKategori = string.IsNullOrEmpty(kategori) || kategori == "SEMUA" || g.Kategori == kategori;
                if (cocokArah && cocokKategori)
                    hasil.Add(g);
            }
            return hasil;
        }

        // Semua transaksi penjualan (untuk tab Transaksi)
        public List<Transaksi> DaftarTransaksi()
        {
            return _repoTransaksi.DapatkanSemua();
        }
    }
}
