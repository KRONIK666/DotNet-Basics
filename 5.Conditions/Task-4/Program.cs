using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter 1st number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter 2nd number: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter 3rd number: ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int temp = 0;

            if (a < b)
            {
                if (a > c)
                {
                    temp = a;
                    a = b;
                    b = temp;
                    Console.WriteLine("Greatest: " + a);
                    Console.WriteLine("Middle: " + b);
                    Console.WriteLine("Smallest: " + c);
                }
                else if (a < c)
                {
                    if (b < c)
                    {
                        temp = a;
                        a = c;
                        c = temp;
                        Console.WriteLine("Greatest: " + a);
                        Console.WriteLine("Middle: " + b);
                        Console.WriteLine("Smallest: " + c);
                    }
                    else
                    {
                        temp = a;
                        a = b;
                        b = c;
                        c = temp;
                        Console.WriteLine("Greatest: " + a);
                        Console.WriteLine("Middle: " + b);
                        Console.WriteLine("Smallest: " + c);
                    }
                }
            }
            else
            {
                if (a < c)
                {
                    temp = a;
                    a = c;
                    c = b;
                    b = temp;
                    Console.WriteLine("Greatest: " + a);
                    Console.WriteLine("Middle: " + b);
                    Console.WriteLine("Smallest: " + c);
                }
                else if (a > c)
                {
                    if (b < c)
                    {
                        temp = b;
                        b = c;
                        c = temp;
                        Console.WriteLine("Greatest: " + a);
                        Console.WriteLine("Middle: " + b);
                        Console.WriteLine("Smallest: " + c);
                    }
                    else
                    {
                        Console.WriteLine("Greatest: " + a);
                        Console.WriteLine("Middle: " + b);
                        Console.WriteLine("Smallest: " + c);
                    }
                }
            } Console.WriteLine();
        }
    }
}