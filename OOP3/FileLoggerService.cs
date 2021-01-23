using System;

namespace OOP3
{
    class FileLoggerService : ILoggerService // Metin dosyasına loglandı.
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı.");
        }
    }
}
