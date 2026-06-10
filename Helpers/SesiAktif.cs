using System;
using System.Collections.Generic;
using System.Text;
using SIKOPI_DOPY_ROASTERY.Models;

namespace SIKOPI_DOPY_ROASTERY.Helpers
{
    public static class SesiAktif
    {
        public static User PenggunaSaatIni { get; set; }

        public static bool SudahLogin
        {
            get { return PenggunaSaatIni != null; }
        }

        public static string Peran
        {
            get
            {
                if (PenggunaSaatIni == null) return null;
                return PenggunaSaatIni.Peran;
            }
        }

        // TAMBAHKAN INI
        public static void Masuk(User user)
        {
            PenggunaSaatIni = user;
        }

        public static void Keluar()
        {
            PenggunaSaatIni = null;
        }
    }
}