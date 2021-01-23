using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class DataBaseLoggerService : ILoggerService //veri tabanına loglama yapacak süreç
    {
        public void Log()
        {
            Console.WriteLine("Veri tabanına loglandı.");
        }
    }
}
