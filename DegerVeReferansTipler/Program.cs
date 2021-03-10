using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 10;
            int sayi2 = 30;
            sayi = sayi2;
            sayi2 = 65;

            Console.WriteLine(sayi);
        }
    }
}
