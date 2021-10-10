using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class KomisiKaryawanDasarPlus : KomisiKaryawan
    {
        private decimal gajiPokok;
        public KomisiKaryawanDasarPlus(string namaDepan, string namaBelakang, string nomorKTP, decimal penjualanKotor, decimal tingkatKomisi, decimal gajiPokok) : base(namaDepan, namaBelakang, nomorKTP, penjualanKotor, tingkatKomisi)
        {
            GajiPokok = gajiPokok;
        }

        public decimal GajiPokok
        {
            get
            {
                return gajiPokok;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(GajiPokok)} harus >= 0");
                }
                gajiPokok = value;
            }
        }
        public override decimal Pendapatan() => GajiPokok + base.Pendapatan();
        public override string ToString() => $"gaji pokok {base.ToString()}\ngaji pokok: {GajiPokok:C}";
    }

}