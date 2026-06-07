using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;

namespace SIKOPI_DOPY_ROASTERY.Data
{
    public static class KoneksiDb
    {
        // Ganti PASSWORD_KAMU sesuai PostgreSQL-mu
        public static string ConnStr =
            "Host=localhost;Port=5432;Username=postgres;Password=PASSWORD_KAMU;Database=sikopi_dopy;";
    }
}