using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter 1, 2 or 3 to input your choice between integer, double or string: ");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    Console.Write("Enter an integer: ");
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Result: " + (a + 1));
                    break;
                case 2:
                    Console.Write("Enter a double: ");
                    double b = double.Parse(Console.ReadLine());
                    Console.WriteLine("Result: " + (b + 1));
                    break;
                case 3:
                    Console.Write("Enter a string: ");
                    string c = Console.ReadLine();
                    Console.WriteLine("Result: " + c + "*");
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            } Console.WriteLine();
        }
    }
}