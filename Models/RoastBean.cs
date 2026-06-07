using System;
using System.Collections.Generic;
using System.Text;

namespace SIKOPI_DOPY_ROASTERY.Models
{
    public class RoastBean : Bahan
    {
        public long IdBatch { get; set; }
        public string RoastLevel { get; set; }

        private decimal _stokGram;
        public decimal StokGram
        {
            get => _stokGram;
            set
            {
                if (value < 0) throw new ArgumentException("Stok gram tidak boleh negatif");
                _stokGram = value;
            }
        }

        public decimal HargaPerGram { get; set; } // 0 = belum diberi harga admin

        // POLYMORPHISM: method sama namanya, hasil beda (gram, bukan Kg)
        public override string DapatkanLabelStok() => $"{StokGram:N0} g";
    }
}
