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
            empWageBuilder.addCompanyEmpWage("Reliance", 100, 20, 240);
            empWageBuilder.addCompanyEmpWage("tata", 100, 20, 208);
            empWageBuilder.addCompanyEmpWage("Microsoft", 100, 20, 180);
            empWageBuilder.ComputeEmpWage();           

        }
    }
}
