using System;

namespace WagesForMonth
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int checkVal = random.Next(0, 3);
            int dailyWage =0;
            int salaryPerHr = 20;
            int dailyHrs = 0;
           switch (checkVal)
            {
                case 0:
                    Console.WriteLine("Employee is Absent");
                    dailyHrs = 0;
                    break;

                case 1:
                    Console.WriteLine("Employee is Full Time");
                    dailyHrs = 16;
                    break;
                case 2:
                    Console.WriteLine("Employee is Part Time");
                    dailyHrs = 8;
                    break;
            }
              
            Console.WriteLine("monthly wage of an employee is:" + dailyWage + salaryPerHr *dailyHrs * 20);
        }
    }
}
