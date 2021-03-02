using System;

namespace EmpPartTimeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            int isFullTime = 0;
            int isPartTime = 1;
            int dailyHrs;
            int dailyWage;
        
            Random random = new Random();
            int checkVal = random.Next(0, 2);
            if (checkVal == isPartTime)
            {
                dailyHrs = 8;
            }
            else
            {
                dailyHrs = 16;
            }
            dailyWage = dailyHrs * 20;
            Console.WriteLine("Daily wage is:" + dailyWage);
        }
    }
}
