using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int greatest = 0;
            int lowest = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter a number: ");
                int num = int.Parse(Console.ReadLine());

                if (i == 0)
                {
                    greatest = num;
                    lowest = num;
                }
                else
                {
                    if (num < lowest)
                    {
                        lowest = num;
                    }
                    else if (num > greatest)
                    {
                        greatest = num;
                    }
                }
            } Console.WriteLine();

            Console.WriteLine("Greatest number: " + greatest);
            Console.WriteLine("Lowest number: " + lowest);
            Console.WriteLine();
        }
    }
}