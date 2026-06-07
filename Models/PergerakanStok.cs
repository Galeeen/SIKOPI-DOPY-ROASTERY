using System;
using System.Collections.Generic;
using System.Text;

namespace SIKOPI_DOPY_ROASTERY.Models
{
    public class PergerakanStok
    {
        public long Id { get; set; }
        public string Arah { get; set; }      // "MASUK" | "KELUAR"
        public string Kategori { get; set; }  // "MENTAH" | "ROASTED"
        public long? IdGreenBean { get; set; }   // boleh kosong (null)
        public long? IdRoastBean { get; set; }   // boleh kosong (null)
        public decimal Jumlah { get; set; }
        public string Satuan { get; set; }    // "kg" | "gram"
        public string Referensi { get; set; }
        public DateTime TanggalGerak { get; set; }
    }
}
