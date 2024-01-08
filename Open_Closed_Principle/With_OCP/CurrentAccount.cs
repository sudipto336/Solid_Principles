using Open_Closed_Principle.With_OCP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle.With_OCP
{
    internal class CurrentAccount : IAccount
    {
        public double CalculateInterest(Account account)
        {
            return account.Balance * 0.2;
        }
    }
}
