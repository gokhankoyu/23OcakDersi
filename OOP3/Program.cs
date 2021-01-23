using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program // İNTERFACE LERİ KONUŞACAĞIZ. //polimorfizm?
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager(); 
            // görüldüğü gibi interfacelerde referans numarasını tutabiliyor.
            // IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            // ihtiyacKrediManager.Hesapla();

            IKrediManager tasitKrediManager = new TasitKrediManager();
            //TasitKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();

            IKrediManager konutKrediManager = new KonutKrediManager();
            // KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            ILoggerService databaseLoggerService = new DataBaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyacKrediManager, new DataBaseLoggerService());
            //basvuruManager.BasvuruYap(konutKrediManager);

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager };
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);


        }
    }
}
