using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage_Batch222
{
     class Empwage
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Employee Wage Computation problem");
            const int is_fulltime = 1;
            const int is_parttime = 2;
            int emphrs = 0, dailywage = 0;
            int totalemphrs = 0;
            int rateperhr = 20;
            const int No_OF_Working_days = 20;
            int monthlywage = 0;
            
            for (int day = 1; day <= No_OF_Working_days; day++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 2);
                switch (empCheck)
                {
                    case is_fulltime:
                        Console.WriteLine("Employee is present full time");
                        emphrs = 8;
                        break;
                    case is_parttime:
                        Console.WriteLine("Employee is present part time");
                        emphrs = 4;
                        break;
                    default:
                        Console.WriteLine("Employee is absent");
                        emphrs = 0;
                        break;
                }
                dailywage = emphrs * rateperhr;
                Console.WriteLine("day{0}-Dailywage is {1}", day, dailywage);
                monthlywage += dailywage;
            }
           
            Console.WriteLine("Monthly wage of employee is " + monthlywage);
        }
    }
}
