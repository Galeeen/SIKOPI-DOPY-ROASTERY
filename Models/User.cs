using System;
using System.Collections.Generic;
using System.Text;

namespace SIKOPI_DOPY_ROASTERY.Models
{
    public class User
    {
        public long Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }   // plaintext, disimpan di kolom password_hash (tanpa hash, sesuai materi)
        public string Nama { get; set; }
        public string Peran { get; set; }   // "admin" | "roaster" | "penjual"
    }
}
