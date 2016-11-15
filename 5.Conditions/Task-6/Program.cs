using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter a number: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter a number: ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("Enter a number: ");
            int d = int.Parse(Console.ReadLine());
            Console.Write("Enter a number: ");
            int e = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int greatest;

            if (a > b)
            {
                greatest = a;

                if (a < c)
                {
                    greatest = c;

                    if (c < d)
                    {
                        greatest = d;

                        if (d < e)
                        {
                            greatest = e;
                        }
                    }
                    else
                    {
                        if (c < e)
                        {
                            greatest = e;
                        }
                    }
                }
                else if (a > c)
                {
                    if (a < d)
                    {
                        greatest = d;

                        if (d < e)
                        {
                            greatest = e;
                        }
                    }
                    else if (a < e)
                    {
                        greatest = e;
                    }
                }
            }
            else
            {
                greatest = b;

                if (b < c)
                {
                    greatest = c;

                    if (c < d)
                    {
                        greatest = d;

                        if (d < e)
                        {
                            greatest = e;
                        }
                    }
                    else
                    {
                        if (c < e)
                        {
                            greatest = e;
                        }
                    }
                }
                else if (b > c)
                {
                    if (b < d)
                    {
                        greatest = d;

                        if (d < e)
                        {
                            greatest = e;
                        }
                    }
                    else if (b < e)
                    {
                        greatest = e;
                    }
                }
            }

            Console.WriteLine("Greatest number is: " + greatest);
            Console.WriteLine();
        }
    }
}