using SIKOPI_DOPY_ROASTERY.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIKOPI_DOPY_ROASTERY.Repositories
{
    public interface IRepositoriPergerakanStok
    {
        List<PergerakanStok> DapatkanSemua();
        long Tambah(PergerakanStok gerak);
    }
}
