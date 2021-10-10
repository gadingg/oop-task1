﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public abstract class Karyawan
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
        public override string ToString() => $"{NamaDepan} {NamaBelakang}\n" + $"Nomor KTP: {NomorKTP}";
        public abstract decimal Pendapatan();
    }
}
