using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your score: ");
            int score = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (score)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("Your total score: " + (score * 10));
                    break;
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("Your total score: " + (score * 100));
                    break;
                case 7:
                case 8:
                case 9:
                    Console.WriteLine("Your total score: " + (score * 1000));
                    break;
                default:
                    Console.WriteLine("Invalid score!");
                    break;
            } Console.WriteLine();
        }
    }
}