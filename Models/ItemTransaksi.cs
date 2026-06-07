using System;
using System.Collections.Generic;
using System.Text;

namespace SIKOPI_DOPY_ROASTERY.Models
{
    public class ItemTransaksi
    {
        public long Id { get; set; }
        public long IdTransaksi { get; set; }
        public long IdRoastBean { get; set; }
        public decimal JumlahGram { get; set; }
        public decimal HargaPerGram { get; set; }
        public decimal Subtotal { get; set; }
    }
}
