using System;

namespace MonthlyWagePerHr
{
    class Program
    {
        static void Main(string[] args)
        {
            int Total_Working_hr = 100;
            int Total_Working_day = 20;
            int j;
            int wages = 0;
            //for (i = 1; i <= Total_Working_day; i++)
            //{
            for (j = 1; j <= Total_Working_hr; j++)

                wages = Total_Working_day * Total_Working_hr;
            Console.WriteLine("Total Working Wages For Month is = {0}", wages);

            //}
        }
    }
}

