using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution_Principle.Without_LSP
{
    internal class ContractualEmployee : Employee
    {
        public override double CalculateSalary()
        {
            return 15000;
        }

        public override double CalculateBonus()
        {
            //As contractual employee should not get bonus
            throw new NotImplementedException();
        }
    }
}
