using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage_Batch222
{
     class EmpWage
    {
        public const int is_Fulltime = 1;
        public const int is_Parttime = 2;
        public const int mAX_HRS_PER_MONTH = 100;
        public const int no_OF_Working_Days = 20;
        public const int empRatePerHr = 20;
        public static int ComputeWage()
        {
            Console.WriteLine("Welcome to Employee Wage Computation problem");
            int empHrs;
            int totalEmpHrs = 0;
            int day = 1;
            while (day <= no_OF_Working_Days && totalEmpHrs <= mAX_HRS_PER_MONTH)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 2);
                switch (empCheck)
                {
                    case is_Fulltime:
                        Console.WriteLine("Employee is present full time");
                        empHrs = 8;
                        break;
                    case is_Parttime:
                        Console.WriteLine("Employee is present part time");
                        empHrs = 4;
                        break;
                    default:
                        Console.WriteLine("Employee is absent");
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine(" Day   #: " + day + "  Employee hours attended till the day  is " + totalEmpHrs);
                day++;
            }
            int totalEmpWage = totalEmpHrs * empRatePerHr;
            Console.WriteLine("  Employee Total monthly wage for Company :" + totalEmpWage);
            return totalEmpWage;
        
        }
        public static void Main(string[] args)
        {
            ComputeWage();

        }
     }
}
