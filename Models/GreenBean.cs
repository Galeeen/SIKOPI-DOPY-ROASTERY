using System;
using System.Collections.Generic;
using System.Text;

namespace SIKOPI_DOPY_ROASTERY.Models
{
    public class GreenBean : Bahan   // <- mewarisi Bahan (Id, Nama, kontrak DapatkanLabelStok)
    {
        public string Asal { get; set; }            // origin — tetap teks bebas (tidak dinormalisasi)

        // 3NF: jenis/metode/grade kini FK ke tabel lookup (simpan id-nya)
        public long IdJenis { get; set; }           // bean_type_id (wajib)
        public long? IdMetode { get; set; }         // process_method_id (boleh null)
        public long? IdGrade { get; set; }          // grade_id (boleh null)

        // Nama lookup untuk DITAMPILKAN (diisi repo lewat JOIN; tidak disimpan di green_beans)
        public string NamaJenis { get; set; }
        public string NamaMetode { get; set; }
        public string NamaGrade { get; set; }

        // ENKAPSULASI: stok tidak boleh negatif (aturan bisnis #5 di spec)
        private decimal _stokKg;
        public decimal StokKg
        {
            get => _stokKg;
            set
            {
                if (value < 0) throw new ArgumentException("Stok Kg tidak boleh negatif");
                _stokKg = value;
            }
        }

        private decimal _hargaPerKg;
        public decimal HargaPerKg
        {
            get => _hargaPerKg;
            set
            {
                if (value < 0) throw new ArgumentException("Harga tidak boleh negatif");
                _hargaPerKg = value;
            }
        }

        // POLYMORPHISM (overriding): GreenBean menampilkan stok dalam Kg
        public override string DapatkanLabelStok() => $"{StokKg:N2} Kg";
    }
}
