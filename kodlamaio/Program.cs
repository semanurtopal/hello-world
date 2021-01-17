using System;

namespace kodlamaio
{
    class Program
    {
        static void Main(string[] args)
        {
            //DONGULER ODEVİM

            Urun urun1 = new Urun();
            urun1.UrunAdi = "Çanta";
            urun1.UrunRengi = "Turuncu";
            urun1.UrunFiyati = "50";

            Urun urun2 = new Urun();
            urun2.UrunAdi = "Ayakkabı";
            urun2.UrunRengi = "Kırmızı";
            urun2.UrunFiyati = "60";

            Urun urun3 = new Urun();
            urun3.UrunAdi = "Elbise";
            urun3.UrunRengi = "Bej";
            urun3.UrunFiyati = "40";

            Urun[] urunler = new Urun[] { urun1, urun2, urun3 };

            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].UrunAdi + " " + urunler[i].UrunRengi + " " + urunler[i].UrunFiyati + "$");
            }

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.UrunAdi + ": " + urun.UrunRengi + ", " + urun.UrunFiyati + "$");
            }

            int j = 0;
            while (j < urunler.Length)
            {
                Console.WriteLine(urunler[j].UrunAdi + " " + urunler[j].UrunRengi + " " + urunler[j].UrunFiyati + "$");
                j += 1;
            }
        }
    }

    class Urun
    {
        public string UrunAdi { get; set; }
        public string UrunRengi { get; set; }
        public string UrunFiyati { get; set; }


    }
}
