using System.Diagnostics;

namespace EmployeeWageComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int FULL_TIME = 1;
            const int PART_TIME = 2;
            const int EMP_RATE_PER_HR = 20;
            const int MAX_WORKING_DAYS = 20;
            int empHrs = 0;
            int empWage = 0;
            int totalWage = 0;
            Console.WriteLine("Welcome to EmployeeWageComputation");
            Random random = new Random();
            for (int day = 1; day <= MAX_WORKING_DAYS; day++)
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
                empWage = EMP_RATE_PER_HR * empHrs;
                totalWage += empWage; //totalWage=totalWage+emoWage
                Console.WriteLine("EmployeeWage:{0}", empWage);
            }
            Console.WriteLine("TotalWage for {0} days is: {1}", MAX_WORKING_DAYS, totalWage);
            Console.ReadLine() ;
        }
    }
} 