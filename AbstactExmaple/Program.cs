using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstactExmaple
{
    class Program
    {
        static void Main()
        {
            FulltimeEmployee fte = new FulltimeEmployee()
            {
                ID = 101,
                FirstName = "Ray Carl",
                LastName = "Brown-Amory",
                AnnualSalary = 30000
            };
            Console.WriteLine(fte.GetFullName());
            Console.WriteLine(fte.GetMonthlySalary());
            Console.WriteLine(".................");


            ContractingEmployee cte = new ContractingEmployee()
            {
                ID = 1012,
                FirstName = "Carl",
                LastName = "Brownies",
                HourlyPay = 350,
                TotalHours = 40
            };
            Console.WriteLine(cte.GetFullName());
            Console.WriteLine(cte.GetMonthlySalary());
        }
    }
       
}

