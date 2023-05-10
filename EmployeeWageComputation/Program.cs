namespace EmployeeWageComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int FULL_TIME = 1;
            const int PART_TIME = 2;
            const int EMP_RATE_PER_HR = 20;
            int empHrs = 0;
            int empWage = 0;
            Console.WriteLine("Welcome to EmployeeWageComputation");
            Random random = new Random();
            int randomInput = random.Next(0, 3);
            if (FULL_TIME == randomInput)
            {
                empHrs = 8;
                Console.WriteLine("Full time employee is present");
            }
            else if (PART_TIME == randomInput)
            {
                empHrs = 4;
                Console.WriteLine("Part time employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
            empWage = EMP_RATE_PER_HR * empHrs;
            Console.WriteLine("EmployeeWage:{0}",empWage);
            Console.ReadLine();
        }
    }
} 