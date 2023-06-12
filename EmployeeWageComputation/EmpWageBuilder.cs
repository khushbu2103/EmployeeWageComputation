using System.Diagnostics;

namespace EmployeeWageComputation
{
    internal class EmpWageBuilder
    {
        public string company;
        public int maxWorkingDay, maxWorkingHrs, empRatePerHr;

        public EmpWageBuilder(string company, int maxWorkingDay, int maxWorkingHrs, int empRatePerHr)
        {
            this.company = company;
            this.maxWorkingDay = maxWorkingDay;
            this.maxWorkingHrs = maxWorkingHrs;
            this.empRatePerHr = empRatePerHr;
        }

            public void CalculateWage()
            {
            const int FULL_TIME = 1;
            const int PART_TIME = 2;

            int empHrs = 0;
            int empWage = 0;
            int totalWage = 0;
            int day = 1;
            int totalHrs = 0;
                Random random = new Random();
                while (day <= maxWorkingDay && totalHrs <= maxWorkingHrs)
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
                    empWage = empRatePerHr * empHrs;
                    totalWage += empWage; //totalWage=totalWage+emoWage
                    totalHrs += empHrs;
                    //Console.WriteLine("EmployeeWage per day{0}:{1}", day, empWage);
                    day++;
                }
                Console.WriteLine("TotalWage {0} for {1} of {2} days and totalhrs:{3}", totalWage, company, (day-1), totalHrs);
                
            }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to EmployeeWageComputation");
            EmpWageBuilder deloitte = new EmpWageBuilder("Deloitte", 24, 120, 40);
            deloitte.CalculateWage();
            EmpWageBuilder Microsoft = new EmpWageBuilder("Microsoft", 34, 100, 46);
            deloitte.CalculateWage();
            EmpWageBuilder Bridgelabz = new EmpWageBuilder("Bridgelabz", 20, 130, 35);
            deloitte.CalculateWage();
            Console.ReadLine();
        }

    }
} 