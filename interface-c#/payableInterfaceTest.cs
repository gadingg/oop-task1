using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Ipayable
{
    class PayableInterfaceTest
    {
        static void Main(string[] args)
        {
            var objekHutang = new List<Ipayable>()
            {
                new Invoice("01234", "seat", 2, 375.00M),
                new Invoice("56789", "tire", 4, 79.95M),
                new KaryawanBergaji("John", "Smith", "111-11-1111", 800.00M),
                new KaryawanBergaji("Lisa", "Barnes", "888-88-8888", 1200.00M)
            };

            Console.WriteLine("Faktur dan Karyawan diproses secara polimorfis:\n");
            foreach (var hutang in objekHutang)
            {
                Console.WriteLine($"{hutang}");
                Console.WriteLine($"tanggal jatuh tempo: {hutang.DapatkanJumlahPembayaran():C}\n");
            }
        }
    }
}