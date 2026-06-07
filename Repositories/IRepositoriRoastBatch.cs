using SIKOPI_DOPY_ROASTERY.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIKOPI_DOPY_ROASTERY.Repositories
{
    public interface IRepositoriRoastBatch
    {
        List<RoastBatch> DapatkanSemua();
        RoastBatch DapatkanById(long id);
        long Tambah(RoastBatch batch);
    }
}
