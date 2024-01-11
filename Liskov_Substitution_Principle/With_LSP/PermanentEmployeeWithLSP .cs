using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution_Principle.With_LSP
{
    internal class PermanentEmployeeWithLSP : EmployeeWithAllBenefits
    {
        public override double CalculateSalary()
        {
            return 20000;
        }
    }
}
