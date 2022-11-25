using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage_Batch222
{
    interface IEmpWagebuilder
    {
        public void addCompanyEmpWage(string company, int mAX_HRS_PER_MONTH, int no_OF_Working_Days, int empRatePerHr);
        public void ComputeEmpWage();
        public void SetTotalEmpWage(int totalEmpWage);
        public string ToString();
    }
}
