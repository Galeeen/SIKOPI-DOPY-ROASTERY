using System;
using System.Collections.Generic;
using System.Text;

namespace SIKOPI_DOPY_ROASTERY.Models
{
    // ABSTRACT = kerangka umum. Tidak bisa di-new langsung (tidak ada "Bahan kopi" generik,
    // yang ada GreenBean atau RoastBean). Persis analogi "Alat Musik" di PPT.
    public abstract class Bahan
    {
        public long Id { get; set; }

        // ENKAPSULASI: field private + Property dengan validasi di setter
        private string _nama;
        public string Nama
        {
            get => _nama;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Nama tidak boleh kosong");
                _nama = value;
            }
        }

        // METHOD ABSTRAK: tiap turunan WAJIB punya caranya sendiri (Polymorphism - overriding)
        public abstract string DapatkanLabelStok();
    }
}
