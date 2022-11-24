using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage_Batch222
{
    class EmpWageBuilderArray 
    {
        public const int is_Fulltime = 1;
        public const int is_Parttime = 2;
        private LinkedList<CompanyEmpWage> companyEmpWageList;
        private Dictionary<string, CompanyEmpWage> companyToEmpWageMap;  


        public EmpWageBuilderArray()
        {
            this.companyEmpWageList = new LinkedList<CompanyEmpWage>();
            this.companyToEmpWageMap = new Dictionary<string, CompanyEmpWage>();
        }
        public void addCompanyEmpWage(string company, int mAX_HRS_PER_MONTH, int no_OF_Working_Days, int empRatePerHr)
        {
            CompanyEmpWage companyEmpWage= new CompanyEmpWage(company, mAX_HRS_PER_MONTH, no_OF_Working_Days, empRatePerHr);
            this.companyEmpWageList.AddLast(companyEmpWage);
            this.companyToEmpWageMap.Add(company, companyEmpWage);
        }
        public void ComputeEmpWage()
        {
           foreach(CompanyEmpWage companyEmpWage in companyEmpWageList)
            {
                companyEmpWage.SetTotalEmpWage(this.ComputeEmpWage(companyEmpWage));
                Console.WriteLine(companyEmpWage.ToString());
            }
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
        public int getTotalWage(string company)
        {
            return this.companyToEmpWageMap[company].totalEmpWage;
        }

    }
}
