using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution_Principle.With_LSP
{
    internal class EmployeeWithAllBenefits
    {
        public virtual double CalculateSalary()
        {
            return 10000;
        }

        public virtual double CalculateBonus()
        {
            return 1000;
        }
    }
}
