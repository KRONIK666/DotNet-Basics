using System;

namespace Task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a 4-digit number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int digit1 = (number / 1000) % 10;
            int digit2 = (number / 100) % 10;
            int digit3 = (number / 10) % 10;
            int digit4 = number % 10;

            int sum = digit1 + digit2 + digit3 + digit4;
            string a = digit1.ToString();
            string b = digit2.ToString();
            string c = digit3.ToString();
            string d = digit4.ToString();

            Console.WriteLine("Your number is: " + number);
            Console.WriteLine("The sum of 4 digits of the number is: " + sum);
            Console.WriteLine("Digits in reverse way: " + d + c + b + a);
            Console.WriteLine("Last digit becomes first: " + d + a + b + c);
            Console.WriteLine("Middle digits switched: " + a + c + b + d);
            Console.WriteLine();
        }
    }
}