using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Emir";
            musteri1.Soyadi = "Sarrafoğlu";
            musteri1.Cinsiyeti = "Erkek";
            

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Lucius";
            musteri2.Soyadi = "Malfoy";
            musteri2.Cinsiyeti = "Erkek";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.Soyadi);
                Console.WriteLine(musteri.Cinsiyeti);
                Console.WriteLine("-------------");
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

            MusteriManager musteriManager2 = new MusteriManager();
            musteriManager.Çıkar(musteri1);
            musteriManager.Çıkar(musteri2);


        }

        

        


}
}
