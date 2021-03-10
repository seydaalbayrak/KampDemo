using System;

namespace Gun2Odev6
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.UrunAdi = "Meyve";
            urun1.UrunFiyati = 11;

            Urun urun2 = new Urun();
            urun2.UrunAdi = "Sebze";
            urun2.UrunFiyati = 14;

            Urun urun3 = new Urun();
            urun3.UrunAdi = "Çilek";
            urun3.UrunFiyati = 75;

            Urun urun4 = new Urun();
            urun4.UrunAdi = "Sakız";
            urun4.UrunFiyati = 4;

            Urun[] urunler = new Urun[] { urun1, urun2, urun3, urun4 };

            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].UrunAdi + " " + urunler[i].UrunFiyati);
            }

            Console.WriteLine("--------------------");

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.UrunAdi + " " + urun.UrunFiyati);
            }

            Console.WriteLine("--------------------");

            int j = 0;
            while (j < urunler.Length)
            {
                Console.WriteLine(urunler[j].UrunAdi + " " + urunler[j].UrunFiyati);
                j++;
            }

            Console.WriteLine("--------------------");

        }
    }
    
    class Urun
    {
        public string UrunAdi { get; set; }
        public decimal UrunFiyati { get; set; }

    }
}
