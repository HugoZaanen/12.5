using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._5
{
    class Program
    {
        static void Main(string[] args)
        {
            //create derived-class objects
            var salariedEmployee = new SalariedEmployee("John", "Smoith",
                "111-11-1111", 800.00M);
            var hourlyEmployee = new HourlyEmployee("Karen", "Price",
                "222-22-2222", 16.75M, 40.0M);
            var commissionEmployee = new CommissionEmployee("Sue","Jones",
                "333-33-3333",10000.00M ,.6M);
            var basePlusCommissionEmployee =
                new BasePlusCommissionEmployee("Bob","Lewis",
                "444-44-4444", 5000.00M,.04M, 300.00M);

            Console.WriteLine("Employees processed individually:\n");

            Console.WriteLine($"{salariedEmployee}\nearned: " +
                $"{salariedEmployee.Earnings():C}\n");
            Console.WriteLine(
                $"{hourlyEmployee}\nearned: {hourlyEmployee.Earnings():C}\n");
            Console.WriteLine($"{commissionEmployee}\nearned: " +
                $"{commissionEmployee.Earnings():C}\n");
            Console.WriteLine($"{basePlusCommissionEmployee}\nearned: " +
                $"{basePlusCommissionEmployee.Earnings():C}\n");

            //create List<Employee> and initialiez with employee objects
            var employees = new List<Employee>() { salariedEmployee,
            hourlyEmployee, commissionEmployee, basePlusCommissionEmployee};

            Console.WriteLine("Employees processed polymorphically:\n");

            //generically process each element in employees
            foreach (var currentEmployee in employees)
            {
                Console.WriteLine(currentEmployee);


                //determine wheter element is a BasePluscommissionEmployee
                if (currentEmployee is BasePlusCommissionEmployee)
                {
                    //downCast Employee reference to
                    //BasePlusCommissionEmployee reference
                    var employee = (BasePlusCommissionEmployee)currentEmployee;

                    employee.BaseSalary *= 1.10M;
                    Console.WriteLine("new base salary with 10% increase is: " +
                        $"{employee.BaseSalary:C}");
                }

                Console.WriteLine($"earned: {currentEmployee.Earnings():C}\n");
            }

            //get type name of each object in employees
            for(int j = 0; j < employees.Count; j++)
            {
                Console.WriteLine(
                    $"Employee {j} is a {employees[j].GetType()}");
            }
            Console.Read();
        }
    }
}