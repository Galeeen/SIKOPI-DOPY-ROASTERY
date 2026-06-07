using SIKOPI_DOPY_ROASTERY.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIKOPI_DOPY_ROASTERY.Repositories
{
    public interface IRepositoriGreenBean
    {
        List<GreenBean> DapatkanSemua();
        GreenBean DapatkanById(long id);
        long Tambah(GreenBean green);
        void Ubah(GreenBean green);
        void Hapus(long id);
    }
}
