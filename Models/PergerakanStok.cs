using System;
using System.Collections.Generic;
using System.Text;

namespace SIKOPI_DOPY_ROASTERY.Models
{
    public class PergerakanStok
    {
        public long Id { get; set; }
        public string Arah { get; set; }      // "IN" | "OUT"
        public string Kategori { get; set; }  // "GREEN" | "ROAST"
        public long? IdGreenBean { get; set; }   // boleh kosong (null)
        public long? IdRoastBean { get; set; }   // boleh kosong (null)
        public decimal Jumlah { get; set; }
        public string Satuan { get; set; }    // "Kg" | "g"
        public string Referensi { get; set; }
        public DateTime TanggalGerak { get; set; }
    }
}
