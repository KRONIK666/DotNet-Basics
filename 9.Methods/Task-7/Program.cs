using System;

namespace Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            string number = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("In reverse the number is: " + ReverseNumber(number));
            Console.WriteLine();
        }

        public static string ReverseNumber(string number)
        {
            char[] charArray = number.ToCharArray();
            Array.Reverse(charArray);

            return new string(charArray);
        }
    }
}