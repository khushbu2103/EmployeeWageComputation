using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class CompanyDetails
    {
        public string company;
        public int maxWorkingDay, maxWorkingHrs, empRatePerHr, totalWage;

        public CompanyDetails(string company, int maxWorkingDay, int maxWorkingHrs, int empRatePerHr)
        {
            this.company = company;
            this.maxWorkingDay = maxWorkingDay;
            this.maxWorkingHrs = maxWorkingHrs;
            this.empRatePerHr = empRatePerHr;
        }
        
        public void SetTotalWage(int totalWage)
        {
            this.totalWage=totalWage;
        }
        public override string ToString()
        {
            return $" comapny:{ company} maxdays:{maxWorkingDay} maxhrs:{maxWorkingHrs} rateperhr:{empRatePerHr} totalwage:{totalWage} ";
        }
    }
}
