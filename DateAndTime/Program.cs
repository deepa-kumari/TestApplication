using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DateAndTime
{
    class Program
    {
        static void Main(string[] args)
        {
           DateTime myValue = DateTime.Now;
           //Console.WriteLine(myValue.ToString());
           //Console.WriteLine(myValue.ToShortDateString());
           //Console.WriteLine(myValue.ToShortTimeString());
           //Console.WriteLine(myValue.AddDays(3).ToShortDateString());
           //Console.WriteLine(myValue.AddDays(-3).ToShortDateString());
           //Console.WriteLine(myValue.AddHours(3).ToShortTimeString());
          // Console.WriteLine(myValue.AddHours(-3).ToShortTimeString());
           //Console.WriteLine(myValue.Month.ToString());
            DateTime myBirthDate = DateTime.Parse("1987/01/07");
            //DateTime myBirthDate = new DateTime(1987, 01, 07);
            TimeSpan myAge = DateTime.Now.Subtract(myBirthDate);
            Console.WriteLine(myAge.TotalDays.ToString());
          
            Console.ReadLine();
        }
    }
}
