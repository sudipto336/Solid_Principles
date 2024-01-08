using Open_Closed_Principle.Without_OCP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle.With_OCP
{
    internal interface IAccount
    {
        double CalculateInterest(Account account);
    }
}
