using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle.Without_OCP
{
    internal class Account
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public double Balance { get; set; }

        public double CalculateInterest(string accountType)
        {
            if (accountType == "Saving")
            {
                return Balance * 0.3;
            } else 
            {
                return Balance * 0.5;
            }
        }
    }
}
