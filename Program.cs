using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage_Batch222
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder.addCompanyEmpWage("Reliance", 100, 30, 240);
            empWageBuilder.addCompanyEmpWage("tata", 120, 26, 208);
            empWageBuilder.addCompanyEmpWage("Microsoft", 150, 26, 180);
            empWageBuilder.ComputeEmpWage();
            Console.WriteLine("Total wage for Reliance company is" + empWageBuilder.getTotalWage("Reliance"));
            Console.WriteLine("Total wage for tata company is" + empWageBuilder.getTotalWage("tata"));
        }
    }
}
