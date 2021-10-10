using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Ipayable
{
    public class Invoice : Ipayable
    {
        public string NomorBagian { get; }
        public string DeskripsiBagian { get; }
        private int kuantitas;
        private decimal hargaPerItem;

        public Invoice(string nomorBagian, string deskripsiBagian, int kuantitas, decimal hargaPerItem)
        {
            NomorBagian = nomorBagian;
            DeskripsiBagian = deskripsiBagian;
            Kuantitas = kuantitas;
            HargaPerItem = hargaPerItem;
        }
        public int Kuantitas
        {
            get
            {
                return kuantitas;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Kuantitas)} harus >= 0");
                }
                kuantitas = value;
            }
        }
        public decimal HargaPerItem
        {
            get
            {
                return hargaPerItem;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(HargaPerItem)} harus >= 0");
                }
                hargaPerItem = value;
            }
        }
        public override string ToString() => $"Invoice:\npart number: {NomorBagian} ({DeskripsiBagian})\n" + $"kuantitas: {Kuantitas}\nharga per item: {HargaPerItem:C}";
        public decimal DapatkanJumlahPembayaran() => Kuantitas * HargaPerItem;
    }
}