using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {//Method injectioon
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)//ben buraya ne kredisi gönderirsem bellekteki kredinin referansı çalışacak.
        {

            //başvuran bilgilerini değerlendirme yaparız. başka şeyler de yaparız.
            //krediyi hesaplayalım

            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();
            //yukarıdaki gibi yaparsak tüm başvurular konutkredisi gibi algılanır.

            //başvuru yaparken bir parametre alalım. bu başvuruyu ahngi kritere göre almam gerektiğini bana söylesin.

            krediManager.Hesapla();
            loggerService.Log();
        }


        //her bir kredinin hesabını yapma
        public void KrediOnBilgilendirmesiYap(List<IKrediManager>krediler) //bana türü IKrediManager olan bir liste ver.
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    
    
    }

}
