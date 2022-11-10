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
            int is_fulltime = 1;
            int is_parttime = 2;
            int emphrs = 0;
            int rateperhr = 20;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == is_fulltime)
            {
                Console.WriteLine("Employee is present full time");
                emphrs = 8;
            }
            else if(empCheck == is_parttime)
            {
                Console.WriteLine("Employee is present part time");
                emphrs = 4;
            }
            else
            {
                Console.WriteLine("Employee is absent");
                emphrs = 0;
            }
            int DailyWage = emphrs * rateperhr;
            Console.WriteLine("Daily wage of employee is " + DailyWage);
        }
    }
}
