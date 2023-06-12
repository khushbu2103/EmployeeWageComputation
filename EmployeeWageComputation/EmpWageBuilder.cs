using System.Diagnostics;

namespace EmployeeWageComputation
{
    internal class EmpWageBuilder
    {
        //int[] arr = new int[5];
        public CompanyDetails[] companies;
        int noOfCompanies = 0;

        public EmpWageBuilder()
        {
            companies = new CompanyDetails[5];
        }

        public void AddCompanyDetails(string company, int maxWorkingDay, int maxWorkingHrs, int empRatePerHr)
        {
            CompanyDetails comp = new CompanyDetails(company, maxWorkingDay, maxWorkingHrs, empRatePerHr);
            companies[noOfCompanies] = comp;
            noOfCompanies++;
        }
        public void IterateOverCompanies()
        {
            for (int i = 0; i < companies.Length; i++)
            {
                if (companies[i] != null)
                {
                    int totalWage = CalculateWage(companies[i]);
                    companies[i].SetTotalWage(totalWage);
                    Console.WriteLine(companies[i]);
                }
            }
        }
            public int CalculateWage(CompanyDetails obj)
            {
            const int FULL_TIME = 1;
            const int PART_TIME = 2;

            int empHrs = 0;
            int empWage = 0;
            int totalWage = 0;
            int day = 1;
            int totalHrs = 0;
                Random random = new Random();
                while (day <= obj.maxWorkingDay && totalHrs <= obj.maxWorkingHrs)
                {

                    int randomInput = random.Next(0, 3);
                    switch (randomInput)
                    {
                        case FULL_TIME:
                            //code block;
                            empHrs = 8;
                            //Console.WriteLine("Full time employee is present");
                            break;
                        case PART_TIME:
                            //code block;
                            empHrs = 4;
                            // Console.WriteLine("Part time employee is present");
                            break;
                        default:
                            //code block;
                            break;
                    }
                    empWage = obj.empRatePerHr * empHrs;
                    totalWage += empWage; //totalWage=totalWage+emoWage
                    totalHrs += empHrs;
                    //Console.WriteLine("EmployeeWage per day{0}:{1}", day, empWage);
                    day++;
                }
                //Console.WriteLine("TotalWage {0} for {1} of {2} days and totalhrs:{3}", totalWage, obj.company, (day-1), totalHrs);
            return totalWage;
            }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to EmployeeWageComputation");
            EmpWageBuilder empWageBuilder = new EmpWageBuilder();
            empWageBuilder.AddCompanyDetails("Deloitte", 24, 120, 40);
            empWageBuilder.AddCompanyDetails("Microsoft", 34, 100, 46);
            empWageBuilder.AddCompanyDetails("Bridgelabz", 20, 130, 35);
            empWageBuilder.IterateOverCompanies();
            Console.ReadLine();
        }

    }
} 