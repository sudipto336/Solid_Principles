using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution_Principle.With_LSP
{
    internal class ContractualEmployeeWithLSP : EmployeeWithLimitedBenefits
    {
        public override double CalculateSalary()
        {
            return 15000;
        }
    }
}
