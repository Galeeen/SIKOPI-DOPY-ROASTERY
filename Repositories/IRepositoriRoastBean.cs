using SIKOPI_DOPY_ROASTERY.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIKOPI_DOPY_ROASTERY.Repositories
{
    public interface IRepositoriRoastBean
    {
        List<RoastBean> DapatkanSemua();
        RoastBean DapatkanById(long id);
        long Tambah(RoastBean roast);
        void Ubah(RoastBean roast);
        void Hapus(long id);
    }
}
