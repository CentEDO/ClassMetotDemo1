using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 101;
            musteri1.Adi = "Ahmet";
            musteri1.Soyadi = "Yilmaz";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 102;
            musteri2.Adi = "Mehmet";
            musteri2.Soyadi = "Solmaz";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 103;
            musteri3.Adi = "Sinan";
            musteri3.Soyadi = "Kaya";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            Console.WriteLine("----//----");

            Console.WriteLine("1.Müşterinin"); musteriManager.Listele(musteri1);
            Console.WriteLine("2.Müşterinin"); musteriManager.Listele(musteri2);
            Console.WriteLine("3.Müşterinin"); musteriManager.Listele(musteri3);
            Console.WriteLine("----//----");

            musteriManager.Silme(musteri1);
            musteriManager.Silme(musteri2);
            musteriManager.Silme(musteri3);


        }
    }
}