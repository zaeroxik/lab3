using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    class CommonLogger : WriterLogger
    {
        ILogger[] _loggers;
        public CommonLogger(ILogger[] loggers)
        {
            _loggers = loggers;
        }
        public override void Log(params string[] messages)
        {
            foreach(ILogger il in _loggers)
            {
                il.Log(messages);
            }
            
        }
        public override void Dispose()
        {
            
        }
    }
}
