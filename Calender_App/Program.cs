using System;

namespace Calender_App
{
    class Program
    {
        static void Main(string[] args)
        {
            YearCollection year = new();
            Month sep = new(Months.September);

            Console.WriteLine(year.Contains(new(Months.September)));

            Console.WriteLine(year[3]);

            foreach (var month in year.GetMonthWithDaysNumber(30))
            {
                Console.WriteLine(month);
            }
        }
    }
}
