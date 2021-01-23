using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {

            GercekMusteri musteri1 = new GercekMusteri();

            musteri1.Adi = "Gökhan";
            musteri1.SoyAdi = "Koyu";
            musteri1.Id = 6;
            musteri1.TcNo = "11111111111";
            musteri1.MusteriNo = "123456";


            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodalama.io";
            musteri2.VergiNo = "65432165";

            //Musteri classı hem gerçek hem tüzel müşterinin referansını tutabiliyor.
            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();


            CustomerManager musteriManager = new CustomerManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
            musteriManager.Add(musteri3);
            musteriManager.Add(musteri4);



            //steri1.SirketAdi = "?"; // bu şirket adının burada ne gereği var, ileride hataya sebep verebilir.

            //gerçek - tüzel şeklinde iki müşteri tipi var ve bunlar birbirine benziyor birbiri yerine kullanılamaz.
            /*
            KolpaMusteri kolpa1 = new KolpaMusteri();
            kolpa1.BabaAdi = "oRHAN";
            kolpa1.Adi = "Gökhan";

            Console.WriteLine(kolpa1.Adi + kolpa1.BabaAdi);
            */



        }
    }
}
