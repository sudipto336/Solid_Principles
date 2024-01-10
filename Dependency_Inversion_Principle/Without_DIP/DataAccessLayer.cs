using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle.Without_DIP
{
    internal class DataAccessLayer
    {
        public void AddEmployee(string name)
        {
            //add employee to db
            //DataAccessLayer - Higher level class
            //FileLogger - Lower level class
            //Higher level class depending upon lower level class
            FileLogger logger = new FileLogger();
            //DbLogger logger = new DbLogger();
            //to replace FileLogger with DbLogger, we need to change code in DataAccessLayer
            logger.Log("Employee added: " + name);
        }
    }
}
