using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class TesSistemPenggajian
    {
        static void Main(string[] args)
        {
            var karyawanBergaji = new KaryawanBergaji("John", "Smith", "111-11-1111", 800.00M);
            var karyawanPerjam = new KaryawanPerJam("Karen", "Price", "222-22-2222", 16.75M, 40.0M);
            var komisiKaryawan = new KomisiKaryawan("Sue", "Jones", "333-33-3333", 10000.00M, .06M);
            var komisiKaryawanDasarPlus = new KomisiKaryawanDasarPlus("Bob", "Lewis", "444-44-4444", 5000.00M, .04M, 300.00M);

            Console.WriteLine("Karyawan diproses secara individual");
            Console.WriteLine($"{karyawanBergaji}\nearned: " + $"{karyawanBergaji.Pendapatan():C}\n");
            Console.WriteLine($"{karyawanPerjam}\nearned: {karyawanPerjam.Pendapatan():C}\n");
            Console.WriteLine($"{komisiKaryawan}\nearned: " + $"{komisiKaryawan.Pendapatan():C}\n");
            Console.WriteLine($"{komisiKaryawanDasarPlus}\nearned:" + $"{komisiKaryawanDasarPlus.Pendapatan():C}\n");

            var karyawan = new List<Karyawan>() { karyawanBergaji, karyawanPerjam, komisiKaryawan, komisiKaryawanDasarPlus };
            Console.WriteLine("Karyawan diproses secara polimorfik");
            foreach (var karyawanSekarang in karyawan)
            {
                Console.WriteLine(karyawanSekarang);
                if (karyawanSekarang is KomisiKaryawanDasarPlus)
                {
                    var karyawan1 = (KomisiKaryawanDasarPlus)karyawanSekarang;
                    karyawan1.GajiPokok *= 1.10M;
                    Console.WriteLine("Gaji pokok baru dengan kenaikan 10% adalah: " + $"{karyawan1.GajiPokok:C}\n");
                }
                for (int j = 0; j < karyawan.Count; j++)
                {
                    Console.WriteLine($"Karyawan {j} adalah {karyawan[j].GetType()}");
                }

            }
        }
    }

}
