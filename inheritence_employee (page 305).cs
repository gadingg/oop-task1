// See https://aka.ms/new-console-template for more information

namespace inheritenceKomisiKaryawan
{
    public class KomisiKaryawan
    {
        public string NamaDepan;
        public string NamaBelakang;
        public string KTP;
        private decimal penjualanKotor;
        private decimal tingkatKomisi;

        public KomisiKaryawan(string namaDepan, string namaBelakang, string KTP, decimal penjualanKotor, decimal tingkatKomisi)
        {
            NamaDepan = namaDepan;
            NamaBelakang = namaBelakang;
            this.KTP = KTP;
            PenjualanKotor = penjualanKotor; 
            TingkatKomisi = tingkatKomisi;
        }
        public void setNamaDepan(string namaDepan)
        {
            NamaDepan = namaDepan;
        }
        public string getNamaDepan()
        {
            return NamaDepan;
        }
        public void setNamaBelakang(string namaBelakang)
        {
            NamaBelakang = namaBelakang;
        }
        public string getNamaBelakang()
        {
            return NamaBelakang;
        }
        public void setKTP(string ktp)
        {
            ktp = KTP;
        }
        public string getKTP()
        {
            return KTP;
        }
        public decimal PenjualanKotor
        {
            get
            {
                return penjualanKotor;
            }
            set
            {
                penjualanKotor = (value < 0) ? 0 : value; 
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
                tingkatKomisi = (value > 0 && value < 1) ? value : 0;
            }
        }

        public decimal Pendapatan()
        {
            return tingkatKomisi * penjualanKotor;
        }

        public override string ToString()
        {
            return string.Format("Nama Depan : {0} \nNama Belakang : {1} \nNomor KTP : {2} \nPenjualan Kotor : {3} \nTingkat Komisi : {4}", NamaDepan, NamaBelakang, KTP, penjualanKotor, tingkatKomisi);
        }
        public class KomisiTambahanKaryawan : KomisiKaryawan
        {
            private decimal gajiPokok;

            public KomisiTambahanKaryawan(string namaDepan, string namaBelakang, string KTP, decimal penjualanKotor, decimal tingkatKomisi, decimal gajiPokok) : base(namaDepan, namaBelakang, KTP, penjualanKotor, tingkatKomisi)
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
                    gajiPokok = (value < 0) ? 0 : value;
                }
            }
            public decimal Pendapatan()
            {
                return tingkatKomisi * penjualanKotor;
            }
        }
        
        static void Main(string[] args)
        {
  
            KomisiKaryawan karyawan = new KomisiKaryawan("Gading", "Utama", "3578011708020001", 1000000M, .1M);

            Console.WriteLine("\t-- Informasi karyawan diperoleh dengan properti dan metode : -- ");
            Console.WriteLine("Nama Depan : {0}", karyawan.NamaDepan);
            Console.WriteLine("Nama Belakang : {0}", karyawan.NamaBelakang);
            Console.WriteLine("Nomor KTP : {0}", karyawan.KTP);
            Console.WriteLine("Penjualan Kotor : {0:C}", karyawan.PenjualanKotor);
            Console.WriteLine("Tingkat Komisi : {0:F2}", karyawan.TingkatKomisi);
            Console.WriteLine("Pendapatan : {0:C}", karyawan.Pendapatan());

            karyawan.PenjualanKotor = 800000M; 
            karyawan.TingkatKomisi = .1M; // menetapkan tingkat  komisi
            Console.WriteLine("\n{0}: --\n{1}", "\t-- Informasi karyawan yang diperbarui diperoleh dari ToString", karyawan);
            Console.WriteLine("Pendapatan : {0:C}", karyawan.Pendapatan());
            Console.ReadLine();
        }
    }
}