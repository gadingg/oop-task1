using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class KaryawanPerJam : Karyawan
    {
        private decimal upah;
        private decimal jam;
        public KaryawanPerJam(string namaDepan, string namaBelakang, string nomorKTP, decimal upahPerJam, decimal jamKerja) : base(namaDepan, namaBelakang, nomorKTP)
        {
            Upah = upahPerJam;
            Jam = jamKerja;
        }

        public decimal Upah
        {
            get
            {
                return upah;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Upah)} harus >= 0");
                }
                upah = value;
            }
        }

        public decimal Jam
        {
            get
            {
                return jam;
            }
            set
            {
                if (value < 0 || value > 168)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Jam)} harus >= 0 dan <= 168");
                }
                jam = value;
            }
        }

        public override decimal Pendapatan()
        {
            if (Jam <= 40)
            {
                return Upah * Jam;
            }
            else
            {
                return (40 * Upah) + ((Jam - 40) * Upah * 1.5M);
            }
        }

        public override string ToString() =>
            $"karyawan per jam: {base.ToString()}\n" +
            $"upah per jam: {Upah:C}\njam kerja: {Jam:F2}";
    }

}
