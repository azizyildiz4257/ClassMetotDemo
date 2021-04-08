using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Musteri_No = 12345;
            musteri1.Adi = "Aziz";
            musteri1.Soyadi = "Yıldız";
            musteri1.Sehir = "Konya";

            Musteri musteri2 = new Musteri();
            musteri2.Musteri_No = 98765;
            musteri2.Adi = "Ahmet";
            musteri2.Soyadi = "Yıldız";
            musteri2.Sehir = "Konya";

            Musteri musteri3 = new Musteri();
            musteri3.Musteri_No = 94625;
            musteri3.Adi = "Rabia";
            musteri3.Soyadi = "Yıldız";
            musteri3.Sehir = "Konya";

            Musteri[] musteris = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);
            musteriManager.Sil(musteri2);
            musteriManager.Listele(musteris);

            Console.Read();
        }
    }
}
