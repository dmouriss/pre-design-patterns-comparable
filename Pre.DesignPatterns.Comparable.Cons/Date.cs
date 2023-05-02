using System;

namespace Pre.DesignPatterns.Comparable.Cons
{
    public class Date : IComparable<Date>
    {
        public int Day { get; }
        public int Month { get; }
        public int Year { get; }
        public Date(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public int CompareTo(Date other)
        {
            if (this.Year != other.Year) 
                return this.Year - other.Year;
            else if (this.Month != other.Month)
                return this.Month - other.Month;
            else
                return this.Day - other.Day;
        }

        public override string ToString()
        {
            return $"{Day}/{Month}/{Year}";
        }
    }
}