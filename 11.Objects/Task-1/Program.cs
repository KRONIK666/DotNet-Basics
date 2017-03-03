using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a valid year: ");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine();

            DateTime Date = new DateTime(year);

            if (DateTime.IsLeapYear(year) == true)
            {
                Console.WriteLine("The year is leap!");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("This is not a leap year.");
                Console.WriteLine();
            }
        }
    }
}