using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage_Batch222
{
    class EmpWageBuilderArray : IEmpWagebuilder
    {
        public const int is_Fulltime = 1;
        public const int is_Parttime = 2;
        public int No_of_Companies = 0;
        private CompanyEmpWage[] CompanyEmpWageArray;        
        public EmpWageBuilderArray()
        {
            this.CompanyEmpWageArray = new CompanyEmpWage[5];        
        }
        public void addCompanyEmpWage(string company, int mAX_HRS_PER_MONTH, int no_OF_Working_Days, int empRatePerHr)
        {
            CompanyEmpWageArray[this.No_of_Companies] = new CompanyEmpWage(company, mAX_HRS_PER_MONTH, no_OF_Working_Days, empRatePerHr);
            No_of_Companies++;
        }
        public void ComputeEmpWage()
        {
            for (int i = 0; i < No_of_Companies; i++)
            {
                CompanyEmpWageArray[i].SetTotalEmpWage(this.ComputeEmpWage(this.CompanyEmpWageArray[i]));
                Console.WriteLine(this.CompanyEmpWageArray[i].ToString());
            }       
        }

        public void SetTotalEmpWage(int totalEmpWage)
        {
            throw new NotImplementedException();
        }

        private int ComputeEmpWage(CompanyEmpWage companyEmpWage)
        {
            Console.WriteLine("Welcome to Employee Wage Computation problem");
            int empHrs;
            int totalEmpHrs = 0;
            int totalWorkingdays = 1;
            while (totalWorkingdays <= companyEmpWage.no_OF_Working_Days && totalEmpHrs <= companyEmpWage.mAX_HRS_PER_MONTH)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 2);
                switch (empCheck)
                {
                    case is_Fulltime:
                        empHrs = 8;
                        break;
                    case is_Parttime:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine(" Day #: " + totalWorkingdays + "  Employee hours : " + totalEmpHrs);
                totalWorkingdays++;
            }
            return totalEmpHrs * companyEmpWage.empRatePerHr;
        }

    }
}
