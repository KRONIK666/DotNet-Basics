using System;
using System.Globalization;

namespace Task_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter start date in format day.month.year: ");
            string firstDate = Console.ReadLine();
            Console.Write("Enter end date in format day.month.year: ");
            string secondDate = Console.ReadLine();
            Console.WriteLine();

            string format = "dd.MM.yyyy";
            DateTime FirstDate = DateTime.ParseExact(firstDate, format, CultureInfo.InvariantCulture.DateTimeFormat);
            DateTime SecondDate = DateTime.ParseExact(secondDate, format, CultureInfo.InvariantCulture.DateTimeFormat);

            Console.WriteLine("The distance between two dates is {0} days.", Math.Abs((SecondDate - FirstDate).Days));
            Console.WriteLine();
        }
    }
}