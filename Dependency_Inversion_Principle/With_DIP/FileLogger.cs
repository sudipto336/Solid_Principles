using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle.With_DIP
{
    internal class FileLogger : ILogger
    {
        public void Log(string message)
        {
           //Logging into file
        }
    }
}
