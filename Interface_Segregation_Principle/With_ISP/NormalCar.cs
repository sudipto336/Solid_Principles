using Interface_Segregation_Principle.Without_ISP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle.With_ISP
{
    internal class NormalCar : IDrive
    {
        public void Drive()
        {
            Console.WriteLine("Driving car...");
        }
    }
}
