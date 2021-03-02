using System;

namespace EmployeeDailyWage
{
    class Program
    {
        static void Main(string[] args)
        {
            int isFullTime = 1;
            int dailyHrs;
            int dailyWage;
            Random random = new Random();
            int checkVal = random.Next(0, 2);
            if (checkVal == isFullTime)
            {
                dailyHrs = 8;
            }
            else
            {
                dailyHrs = 0;
            }
            dailyWage = dailyHrs * 20;
            Console.WriteLine("Daily wage of an employee is:" + dailyWage);
        }
    }
}
