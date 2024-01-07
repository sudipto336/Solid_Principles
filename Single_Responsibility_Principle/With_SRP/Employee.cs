using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility_Principle.With_SRP
{
    internal class Employee
    {
        private int Id;
        private string? Name;
        private int Age;
        private string? department;
        private double Salary;

        //own responsibility
        public double GetSalary() { return this.Salary; }

        //own responsibility
        public string GetDepartment() { return "IT"; }
    }
}

