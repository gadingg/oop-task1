using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Ipayable
{
    public abstract class Karyawan : Ipayable
    {
        public string NamaDepan { get; }
        public string NamaBelakang { get; }
        public string NomorKTP { get; }

        public Karyawan(string namaDepan, string namaBelakang, string nomorKTP)
        {
            NamaDepan = namaDepan;
            NamaBelakang = namaBelakang;
            NomorKTP = nomorKTP;
        }
        public override string ToString() => $"{NamaDepan} {NamaBelakang}\n" + $"nomorKTP: {NomorKTP}";
        public abstract decimal Pendapatan();
        public decimal DapatkanJumlahPembayaran() => Pendapatan();
    }
}