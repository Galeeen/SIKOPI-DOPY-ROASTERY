using SIKOPI_DOPY_ROASTERY.Helpers;
using SIKOPI_DOPY_ROASTERY.Models;
using SIKOPI_DOPY_ROASTERY.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIKOPI_DOPY_ROASTERY.Controllers
{
    public class AuthController
    {
        private readonly RepositoriUser _repoUser;
        public AuthController(RepositoriUser repoUser) { _repoUser = repoUser; }

        public User Login(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                return null;

            var pengguna = _repoUser.DapatkanByUsername(username);

            if (pengguna == null) return null;
            if (pengguna.Password != password) return null;

            return pengguna;
        }
    }
}