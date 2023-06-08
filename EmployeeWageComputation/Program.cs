using System.Diagnostics;

namespace EmployeeWageComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to EmployeeWageComputation");
            CalculateWage("Delloit" , 24, 120, 40);
            CalculateWage("Microsoft", 34, 100, 46);
            CalculateWage("Bridgelabz", 20, 130, 35);
            Console.ReadLine();
        }


            public static void CalculateWage(string company, int maxWorkingDay, int maxWorkingHrs, int empRatePerHr)
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

        
        
    }
} 