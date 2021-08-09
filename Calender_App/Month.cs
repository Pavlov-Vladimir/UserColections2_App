namespace Calender_App
{
    public enum Months
    {
        January = 1, February, March, April, May, June, July, August, September, October, November, December
    }

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
            return $"Month {Number} is {Name}, \t days in month: {Days}";
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType())
                return false;

            return (this.Name == ((Month)obj).Name);
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
}
