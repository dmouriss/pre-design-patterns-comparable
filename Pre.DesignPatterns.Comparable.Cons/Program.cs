using System;
using System.Collections.Generic;
using System.Globalization;

namespace Pre.DesignPatterns.Comparable.Cons
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      List<Date> dates = new List<Date>() 
        { new Date(3, 10, 1990),
          new Date(2, 8, 2003),
          new Date(8, 4, 1985), 
          new Date(1, 4, 2003) };
      
      dates.Sort();

      foreach (Date date in dates)
      {
        Console.WriteLine(date);
      }
    }
  }
}