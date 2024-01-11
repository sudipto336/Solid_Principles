using Liskov_Substitution_Principle.With_LSP;
using Liskov_Substitution_Principle.Without_LSP;

namespace Liskov_Substitution_Principle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Without_LSP

            Employee employee = new Employee();
            PermanentEmployee permanentEmployee = new PermanentEmployee();
            ContractualEmployee contractualEmployee = new ContractualEmployee();

            Console.WriteLine(employee.CalculateSalary());
            Console.WriteLine(employee.CalculateBonus());

            //replacing parent class obj with child class obj

            Console.WriteLine(permanentEmployee.CalculateSalary());
            Console.WriteLine(permanentEmployee.CalculateBonus());

            Console.WriteLine(contractualEmployee.CalculateSalary());
            Console.WriteLine(contractualEmployee.CalculateBonus());//throws error - violating LSP



            //With_LSP

            EmployeeWithAllBenefits employeeWithAllBenefits = new EmployeeWithAllBenefits();
            EmployeeWithLimitedBenefits employeeWithLimitedBenefits = new EmployeeWithLimitedBenefits();
            PermanentEmployeeWithLSP permanentEmployeeWithLSP = new PermanentEmployeeWithLSP();
            ContractualEmployeeWithLSP contractualEmployeeWithLSP = new ContractualEmployeeWithLSP();

            Console.WriteLine(employeeWithAllBenefits.CalculateSalary());
            Console.WriteLine(employeeWithAllBenefits.CalculateBonus());

            Console.WriteLine(permanentEmployeeWithLSP.CalculateSalary());
            Console.WriteLine(permanentEmployeeWithLSP.CalculateBonus());

            Console.WriteLine(employeeWithLimitedBenefits.CalculateSalary());

            Console.WriteLine(contractualEmployeeWithLSP.CalculateSalary());
        }
    }
}
