using System;
using System.Collections.Generic;
using System.Text;

namespace SIKOPI_DOPY_ROASTERY.Models
{
    public class Lookup
    {
        public long Id { get; set; }
        public string Nama { get; set; }
        public override string ToString() => Nama;  // biar ComboBox menampilkan Nama
    }
}
