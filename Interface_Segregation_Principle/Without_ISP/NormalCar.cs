using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle.Without_ISP
{
    internal class NormalCar : IFly
    {
        public void Drive()
        {
            Console.WriteLine("Driving car...");
        }

        //forcefully implementing extra method
        public void Fly()
        {
            throw new NotImplementedException();
        }
    }
}
