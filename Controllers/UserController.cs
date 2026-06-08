using SIKOPI_DOPY_ROASTERY.Helpers;
using SIKOPI_DOPY_ROASTERY.Repositories;
using SIKOPI_DOPY_ROASTERY.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIKOPI_DOPY_ROASTERY.Controllers
{
    public class UserController
    {
        private readonly RepositoriUser _repoUser;
        public UserController(RepositoriUser repoUser) { _repoUser = repoUser; }

        public List<User> DaftarUser()
        {
            return _repoUser.DapatkanSemua();
        }

        public void TambahUser(string username, string password, string nama, string peran)
        {
            if (string.IsNullOrWhiteSpace(username)) throw new ArgumentException("Username wajib diisi");
            if (string.IsNullOrWhiteSpace(password)) throw new ArgumentException("Password wajib diisi");
            if (peran != "admin" && peran != "roaster" && peran != "penjual")
                throw new ArgumentException("Peran harus admin, roaster, atau penjual");

            // cegah username kembar
            if (_repoUser.DapatkanByUsername(username) != null)
                throw new ArgumentException("Username sudah dipakai");

            var user = new User { Username = username, Password = password, Nama = nama, Peran = peran };
            _repoUser.Tambah(user);
        }

        public void UbahUser(long id, string username, string password, string nama, string peran)
        {
            if (string.IsNullOrWhiteSpace(username)) throw new ArgumentException("Username wajib diisi");
            if (peran != "admin" && peran != "roaster" && peran != "penjual")
                throw new ArgumentException("Peran tidak valid");

            var user = new User { Id = id, Username = username, Password = password, Nama = nama, Peran = peran };
            _repoUser.Ubah(user);
        }

        public void HapusUser(long id)
        {
            // ATURAN: tidak boleh menghapus diri sendiri
            if (SesiAktif.PenggunaSaatIni != null && id == SesiAktif.PenggunaSaatIni.Id)
                throw new ArgumentException("Tidak boleh menghapus akun yang sedang login");
            _repoUser.Hapus(id);
        }
    }
}
