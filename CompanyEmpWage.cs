using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage_Batch222
{   
    internal class CompanyEmpWage
    {
        public string company;
        public int mAX_HRS_PER_MONTH;
        public int no_OF_Working_Days;
        public int empRatePerHr;
        public int totalEmpWage; 
        public CompanyEmpWage(string company, int mAX_HRS_PER_MONTH, int no_OF_Working_Days, int empRatePerHr)
        {
            this.company = company;
            this.mAX_HRS_PER_MONTH = mAX_HRS_PER_MONTH;
            this.no_OF_Working_Days = no_OF_Working_Days;
            this.empRatePerHr = empRatePerHr;       
        }
        public void SetTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }
        public string ToString()
        {
            return "Total Employee Wage for the Company " + this.company + " is " + this.totalEmpWage;
        }
    }
}
