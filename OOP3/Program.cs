using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();         
            IKrediManager tasitKrediManager = new TasitKrediManager();          
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyacKrediManager,new List<ILoggerService> { new DatabeseLoggerService(),new FileLoggerService()});

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager ,tasitKrediManager};
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
