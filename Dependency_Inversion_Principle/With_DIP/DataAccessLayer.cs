using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle.With_DIP
{
    internal class DataAccessLayer
    {
        //to replace FileLogger with DbLogger or vice versa, we dont need to change code in DataAccessLayer
        private readonly ILogger logger;
        public DataAccessLayer(ILogger logger) { 
            this.logger = logger;
        }
        public void AddEmployee(string name)
        {
            logger.Log("Employee added: " + name);
        }
    }
}
