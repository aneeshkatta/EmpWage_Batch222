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
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == is_fulltime) 
            Console.WriteLine("Employee is present");
            else
            Console.WriteLine("Employee is absent");
        }
    }
}
