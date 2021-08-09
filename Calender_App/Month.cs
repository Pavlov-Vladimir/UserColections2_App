using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calender_App
{
    public enum Months
    {
        January = 1, February, March, April, May, June, July, August, September, October, November, December
    }

    //public enum MonthDays
    //{
    //    January = 31,
    //    February = 28,
    //    March = 31,
    //    April = 30,
    //    May = 31,
    //    June = 30,
    //    July = 31,
    //    August = 31,
    //    September = 30,
    //    October = 31,
    //    November = 30,
    //    December = 31
    //}

    class Month
    {
        private int _days;

        public string Name { get; }
        public int Number { get; }
        public int Days
        {
            get => _days;
            private set
            {
                if (value == (int)Months.February)
                    _days = 28;
                else if (value == (int)Months.April || value == (int)Months.June ||
                         value == (int)Months.September || value == (int)Months.November)
                    _days = 30;
                else
                    _days = 31;
            }
        }

        public Month(Months month)
        {
            Name = month.ToString();
            Number = (int)month;
            Days = Number;
        }

        public override string ToString()
        {
            return $"Month: {Name} ({Number}), days in month: {Days}";
        }
    }
}
