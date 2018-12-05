using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ContractEmployee cte = new ContractEmployee()
            {
                FirstName = "Joe",
                LastName = "Callahan",
                IDNumber = 203,
                HoursPerMonth = 40,
                PayPerHour = 50
            };

            Console.WriteLine(cte.GetFullName());
            Console.WriteLine(cte.GetMonthlyPay());

            Console.WriteLine("-------------------------------");

            FullTimeEmployee fte = new FullTimeEmployee()
            {
                FirstName = "Charlie",
                LastName = "Day",
                IDNumber = 102,
                SalaryAnnual = 50000
            };

            Console.WriteLine(fte.GetFullName());
            Console.WriteLine(fte.GetMonthlyPay());


        }
    }
}
