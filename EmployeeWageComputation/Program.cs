namespace EmployeeWageComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int FULL_TIME = 1;
            const int EMP_RATE_PER_HR = 20;
            int empHrs = 0;
            int empWage = 0;
            Console.WriteLine("Welcome to EmployeeWageComputation");
            Random random = new Random();
            int randomInput=random.Next(0, 2);
            if (FULL_TIME==randomInput)
            {
                Console.WriteLine("Employee is present");
                empHrs = 8;
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