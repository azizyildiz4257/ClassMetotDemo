using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri No : " + musteri.Musteri_No);
            Console.WriteLine("Müşteri Adı : " + musteri.Adi);
            Console.WriteLine("Müşteri Soyadı : " + musteri.Soyadi);
            Console.WriteLine("Müşteri Şehir : " + musteri.Sehir);
            Console.WriteLine("Müşteri Ekleme İşlemi Başarıyla Gerçekleştirildi.");
            Console.Write("\n");
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri No : " + musteri.Musteri_No);
            Console.WriteLine("Müşteri Adı : " + musteri.Adi);
            Console.WriteLine("Müşteri Soyadı : " + musteri.Soyadi);
            Console.WriteLine("Müşteri Şehir : " + musteri.Sehir);
            Console.WriteLine("Müşteri Silme İşlemi Başarıyla Gerçekleştirildi.");
            Console.Write("\n");
        }

        public void Listele(Musteri[] musteris)
        {
            foreach (var customers in musteris)
            {
                Console.WriteLine("Müşteri No : " + customers.Musteri_No);
                Console.WriteLine("Müşteri Adı : " + customers.Adi);
                Console.WriteLine("Müşteri Soyadı : " + customers.Soyadi);
                Console.WriteLine("Müşteri Şehir : " + customers.Sehir);
                Console.Write("\n");
            }            
        }
    }
}
