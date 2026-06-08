using System;
using System.Collections.Generic;
using System.Text;

namespace SIKOPI_DOPY_ROASTERY.Models
{
    public class RoastBatch
    {
        public long Id { get; set; }
        public string KodeBatch { get; set; }
        public long IdGreenBean { get; set; }
        public long IdOperator { get; set; }
        public decimal GreenDipakaiKg { get; set; }
        public decimal HasilGram { get; set; }
        public long IdTingkatRoasting { get; set; }   // 3NF: roast_level_id (FK ke roast_levels)
        public string RoastLevel { get; set; }         // hanya untuk DITAMPILKAN (diisi repo lewat JOIN)
        public DateTime TanggalBatch { get; set; }
    }
}
