using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    class FileLogger : WriterLogger
    {
        string _name;
        public FileLogger(string name)
        {
            _name = name;
        }
        public override void Log(params string[] messages)
        {
            using FileStream fileStream = File.Open(_name, FileMode.Append);
            using (StreamWriter writerFile = new StreamWriter(fileStream))
            {
                for (int i = 0; i < messages.Length; i++)
                {
                    DateTime dt = DateTime.Now;
                    string s = dt.ToString("yyyy-MM-ddTHH:mm:sszzz: ");
                    if (i < 1)
                    {
                        writerFile.Write(s);
                    }
                    writerFile.Write($"{messages[i]} ");

                    if (messages.Length == 1)
                    {
                        writerFile.WriteLine();
                        return;
                    }
                    else
                        continue;
                }
                writerFile.WriteLine("\n");
                writerFile.Flush();
            }                       
        }
        public override void Dispose()
        {
            
        }
    }
}
