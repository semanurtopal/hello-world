using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri listeye eklendi : " + musteri.Adi);
        }

        public void Çıkar(Musteri musteri) 
        {
            Console.WriteLine("Müşteri listeden çıkarıldı : " + musteri.Adi);
        }
    }
}
