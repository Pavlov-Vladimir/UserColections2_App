using System;

namespace Calender_App
{
    class Program
    {
        static void Main()
        {
            YearCollection year = new();
            //Month sep = new(Months.September);

            Console.WriteLine(year.Contains(new(Months.September)));

            Console.WriteLine(year[3]);
            Console.WriteLine("-------");

            foreach (var month in year.GetMonthWithDaysNumber(30))
            {
                Console.WriteLine(month);
            }
            Console.WriteLine("-------");

            year.Clear();
            Console.WriteLine(year.Contains(new(Months.September)));
            Console.WriteLine("-------");

            foreach (var month in year.GetMonthWithDaysNumber(30))
            {
                Console.WriteLine(month);
            }
            Console.WriteLine("-------");

            year.Add(new Month(Months.December));
            int number = 1;
            foreach (var month in year)
            {
                Console.WriteLine(number++ + " - " + month);
            }
        }
    }
}
