using System;
using System.Collections.Generic;
using System.Text;

namespace SIKOPI_DOPY_ROASTERY.Models
{
    public class Transaksi
    {
        public long Id { get; set; }
        public string Invoice { get; set; }
        public long IdKasir { get; set; }
        public string NamaPelanggan { get; set; }
        public decimal Total { get; set; }
        public DateTime TanggalTransaksi { get; set; }
    }
}
