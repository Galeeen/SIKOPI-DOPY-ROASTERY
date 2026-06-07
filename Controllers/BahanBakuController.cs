using SIKOPI_DOPY_ROASTERY.Models;
using SIKOPI_DOPY_ROASTERY.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIKOPI_DOPY_ROASTERY.Controllers
{
    public class BahanBakuController
    {
        private readonly RepositoriGreenBean _repoGreen;
        private readonly RepositoriRoastBean _repoRoast;

        public BahanBakuController(RepositoriGreenBean repoGreen, RepositoriRoastBean repoRoast)
        {
            _repoGreen = repoGreen;
            _repoRoast = repoRoast;
        }

        public List<GreenBean> DaftarGreenBean()
        {
            return _repoGreen.DapatkanSemua();
        }

        public List<RoastBean> DaftarRoastBean()
        {
            return _repoRoast.DapatkanSemua();
        }

        public void TambahGreenBean(string nama, string asal, string tipe, decimal stok, decimal harga)
        {
            if (string.IsNullOrWhiteSpace(nama)) throw new ArgumentException("Nama wajib diisi");
            // Validasi stok/harga sudah otomatis oleh setter Model (Enkapsulasi)
            var green = new GreenBean { Nama = nama, Asal = asal, Tipe = tipe, StokKg = stok, HargaPerKg = harga };
            long idBaru = _repoGreen.Tambah(green);

            // Catat pergerakan stok IN GREEN (aturan bisnis)
            _repoGreen.CatatGerakMasukGreen(idBaru, stok, "manual");
        }

        public void SetHargaRoastBean(long idRoast, decimal hargaPerGram)
        {
            if (hargaPerGram <= 0) throw new ArgumentException("Harga harus lebih dari 0");
            _repoRoast.SetHarga(idRoast, hargaPerGram);
        }
    }
}
