﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle.Without_ISP
{
    internal class FlyingCar : IFly
    {
        public void Drive()
        {
            Console.WriteLine("Driving car...");
        }

        public void Fly()
        {
            Console.WriteLine("Flying car...");
        }
    }
}
