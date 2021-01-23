using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface IKrediManager // ÖNEMLİ interfaceleri birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız. kredi türlerinin hepsinde ödeme vardır, faiz vardır ama kredi türlerine göre bu hesaplama işlemleri değişkenlik gösterir.
    {// ÖRNEĞİN projede loglama (kim ne zaman hangi operasyonu çağırdı) yapmak istiyoruz diyelim.
        //loglar bir dosyada, veri tabanında tutabiliriz. sms olarak iletebiliriz(örnek kredi başvuran kişiye sms veya e mail atmak vb.) hepsi logluyor. hepsinin imzası aynı. ama hepsinin kodu farklı.
        void Hesapla(); // bu hesaplama işini tüm kredi türleri farklı şekilde ele alır. tek başına bizim için anlam ifade etmiyo.
        //imzanın aynı olduğu...  
        //bir interface derki eğerki birisi bu interfacei kullanırsa o arkadaşım yularıdaki metodu içermek zorunda.

        void BiseyYap();

    }
}
