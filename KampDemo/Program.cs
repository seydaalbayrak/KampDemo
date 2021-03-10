using System;

namespace KampDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            //Do not repeat yourself - Kendini tekrarlama
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.25;
            double dolarBugun = 7.25;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("azalma butonu");

            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("artış butonu");

            }
            else
            {
                Console.WriteLine("eşit");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Ayarlar butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);
        }
    }
}
