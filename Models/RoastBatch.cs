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
        public string RoastLevel { get; set; }
        public DateTime TanggalBatch { get; set; }
    }
}
