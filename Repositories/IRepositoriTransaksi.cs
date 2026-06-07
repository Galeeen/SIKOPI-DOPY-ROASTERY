using SIKOPI_DOPY_ROASTERY.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIKOPI_DOPY_ROASTERY.Repositories
{
    public interface IRepositoriTransaksi
    {
        List<Transaksi> DapatkanSemua();
        Transaksi DapatkanById(long id);
        long Tambah(Transaksi transaksi);
    }
}
