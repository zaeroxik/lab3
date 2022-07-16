using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    class SocketLogger : WriterLogger
    {
        public SocketLogger(string name, int port)
        {

        }
        public override void Log(params string[] messages)
        {
        }
        public override void Dispose()
        {

        }
    }
}
