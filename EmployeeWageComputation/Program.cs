﻿using System.Diagnostics;

namespace EmployeeWageComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculateEmployeeWage calculateEmployeeWage = new CalculateEmployeeWage();
            calculateEmployeeWage.CalculateWage();
        }


        internal class CalculateEmployeeWage
        {
            const int FULL_TIME = 1;
            const int PART_TIME = 2;
            const int EMP_RATE_PER_HR = 20;
            const int MAX_WORKING_DAYS = 20;
            const int MAX_WORKING_HRS = 100;
            int empHrs = 0;
            int empWage = 0;
            int totalWage = 0;
            int day = 1;
            int totalHrs = 0;

            public void CalculateWage()
            {
                Console.WriteLine("Welcome to EmployeeWageComputation");
                Random random = new Random();
                while (day <= MAX_WORKING_DAYS && totalHrs <= MAX_WORKING_HRS)
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
                    totalHrs += empHrs;
                    Console.WriteLine("EmployeeWage per day{0}:{1}", day, empWage);
                    day++;
                }
                Console.WriteLine("TotalWage for {0} days and hrs{1} is: {2}", (day - 1), totalHrs, totalWage);
                Console.ReadLine();
            }

        }  
        
    }
} 