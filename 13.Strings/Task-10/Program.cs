using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter start date in format day.month.year: ");
            string startDate = Console.ReadLine();
            Console.Write("Enter end date in format day.month.year: ");
            string endDate = Console.ReadLine();
            Console.WriteLine();

            string format = "dd.mm.yyyy";
            CultureInfo bg = new CultureInfo("bg-BG");
            DateTime date1 = DateTime.ParseExact(startDate, format, bg);
            DateTime date2 = DateTime.ParseExact(endDate, format, bg);

            Console.WriteLine("The distance between two dates is {0} days.", DaysBetweenDates(date1, date2));
            Console.WriteLine();
        }

        static int DaysBetweenDates(DateTime date1, DateTime date2)
        {
            TimeSpan span = date2.Subtract(date1);
            return (int)span.TotalDays;
        }
    }
}