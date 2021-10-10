using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class KomisiKaryawan : Karyawan
    {
        private decimal penjualanKotor;
        private decimal tingkatKomisi;

        public KomisiKaryawan(string namaDepan, string namaBelakang, string nomorKTP, decimal penjualanKotor, decimal tingkatKomisi) : base(namaDepan, namaBelakang, nomorKTP)
        {
            PenjualanKotor = penjualanKotor;
            TingkatKomisi = tingkatKomisi;
        }

        public decimal PenjualanKotor
        {
            get
            {
                return penjualanKotor;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(PenjualanKotor)} harus >= 0");
                }
                penjualanKotor = value;
            }
        }

        public decimal TingkatKomisi
        {
            get
            {
                return tingkatKomisi;
            }
            set
            {
                if (value <= 0 || value >= 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(TingkatKomisi)} harus > 0 dan < 1");
                }
                tingkatKomisi = value;
            }
        }

        public override decimal Pendapatan() => TingkatKomisi * PenjualanKotor;
        public override string ToString() =>
            $"komisi karyawan: {base.ToString()}\n" +
            $"penjualan kotor: {PenjualanKotor:C}\n" +
            $"tingkat komisi: {TingkatKomisi:F2}";
    }

}
