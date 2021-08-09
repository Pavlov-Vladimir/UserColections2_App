using System;
using System.Collections;

namespace Calender_App
{
    class YearCollection
    {
        private Month[] months = new Month[12];

        public Month this[int index]
        {
            get
            {
                if (index < 1 || index > 12)
                    throw new IndexOutOfRangeException();

                return months[index - 1];
            }
        }

        public YearCollection()
        {
            months[0] = new Month(Months.January);
            months[1] = new Month(Months.February);
            months[2] = new Month(Months.March);
            months[3] = new Month(Months.April);
            months[4] = new Month(Months.May);
            months[5] = new Month(Months.June);
            months[6] = new Month(Months.July);
            months[7] = new Month(Months.August);
            months[8] = new Month(Months.September);
            months[9] = new Month(Months.October);
            months[10] = new Month(Months.November);
            months[11] = new Month(Months.December);
        }

        public void Add(Month month)
        {
            months[month.Number - 1] = month;
        }

        public void Clear()
        {
            months = new Month[12];
        }

        public bool Contains(Month month)
        {
            for (int i = 0; i < months.Length; i++)
            {
                if (months[i] != null && months[i].Equals(month))
                    return true;
            }
            return false;
        }

        public IEnumerable GetMonthWithDaysNumber(int days)
        {
            for (int i = 0; i < months.Length; i++)
            {
                if (months[i]?.Days == days)
                    yield return months[i];
            }
        }


        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < months.Length; i++)
            {
                yield return months[i];
            }
        }
    }
}
