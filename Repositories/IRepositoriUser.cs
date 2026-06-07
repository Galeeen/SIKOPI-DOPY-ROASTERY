using System;
using System.Collections.Generic;
using System.Text;
using SIKOPI_DOPY_ROASTERY.Models;  // ← tambah ini

namespace SIKOPI_DOPY_ROASTERY.Repositories
{
    public interface IRepositoriUser
    {
        List<User> DapatkanSemua();
        User DapatkanById(long id);
        User DapatkanByUsername(string username);  // khusus dipakai saat login
        long Tambah(User user);
        void Ubah(User user);
        void Hapus(long id);
    }
}
