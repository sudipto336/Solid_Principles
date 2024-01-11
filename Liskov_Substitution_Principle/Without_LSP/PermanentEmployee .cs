using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution_Principle.Without_LSP
{
    internal class PermanentEmployee: Employee
    {
        public override double CalculateSalary()
        {
            return 20000;
        }
    }
}
