using SIKOPI_DOPY_ROASTERY.Helpers;
using SIKOPI_DOPY_ROASTERY.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIKOPI_DOPY_ROASTERY.Controllers
{
    public class AuthController
    {
        private readonly RepositoriUser _repoUser;
        public AuthController(RepositoriUser repoUser) { _repoUser = repoUser; }  // CONSTRUCTOR injection

        public bool Login(string username, string password)
        {
            var pengguna = _repoUser.DapatkanByUsername(username);
            if (pengguna == null) return false;
            if (pengguna.Password != password) return false;  // bandingkan langsung (tanpa hash)
            SesiAktif.PenggunaSaatIni = pengguna;   // simpan ke sesi
            return true;
        }
    }
}
