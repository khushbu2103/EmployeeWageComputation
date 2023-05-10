namespace EmployeeWageComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int IS_PRESENT = 1;
            Console.WriteLine("Welcome to EmployeeWageComputation");
            Random random = new Random();
            int randomInput=random.Next(0, 2);
            if (IS_PRESENT==randomInput)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
            Console.ReadLine();
        }
    }
} 