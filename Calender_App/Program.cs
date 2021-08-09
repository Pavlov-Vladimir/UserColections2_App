using System;

namespace Calender_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Month jan = new(Months.January);
            Console.WriteLine(jan);
        }
    }
}
