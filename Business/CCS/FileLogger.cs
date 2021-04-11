using System;
using System.Collections.Generic;
using System.Text;

namespace Business.CCS
{
    //Logları dosyaya almak için kullanılır.
    public class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı");
        }
    }
}
