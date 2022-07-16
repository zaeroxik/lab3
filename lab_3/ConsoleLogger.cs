using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    class ConsoleLogger : WriterLogger
    {

        public override void Log(params string[] messages)
        {
            writer = Console.Out;
            for (int i = 0; i < messages.Length; i++)
            {
                DateTime dt = DateTime.Now;
                string s = dt.ToString("yyyy-MM-ddTHH:mm:sszzz: ");
                if (i < 1)
                {
                    writer.Write(s);
                }
                writer.Write($"{messages[i]} ");

                if (messages.Length == 1)
                {
                    writer.WriteLine();
                    return;
                }
                else
                    continue;
            }
            writer.Flush();
        }
        public override void Dispose()
        {
           
        }
    }
}
