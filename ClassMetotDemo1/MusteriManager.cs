using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Musteri Eklendi : " + musteri.Adi);
        }
        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Adı : " + musteri.Adi);
            Console.WriteLine("Soyadı : " + musteri.Soyadi);
            Console.WriteLine("ID'si : " + musteri.Id);

        }
        public void Silme(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " Bey artık müşteriniz değil");

        }

    }
}