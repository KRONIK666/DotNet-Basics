using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter length of array: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int[] myArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter an element: ");
                myArray[i] = int.Parse(Console.ReadLine());
            } Console.WriteLine();

            Console.Write("Enter position in the array: ");
            int position = int.Parse(Console.ReadLine());
            Console.WriteLine();

            CompareNumber(myArray, position);
            Console.WriteLine();
        }

        public static void CompareNumber(int[] myArray, int position)
        {
            if (position == 0)
            {
                if (myArray[0] < myArray[1])
                {
                    Console.WriteLine("{0} is smaller than it's right.", myArray[0]);
                }
                else if (myArray[0] > myArray[1])
                {
                    Console.WriteLine("{0} is bigger than it's right.", myArray[0]);
                }
                else
                {
                    Console.WriteLine("{0} is equal to it's right.", myArray[0]);
                }
            }
            else if (position == myArray.Length - 1)
            {
                if (myArray[myArray.Length - 1] < myArray[myArray.Length - 2])
                {
                    Console.WriteLine("{0} is smaller than it's left.", myArray[position]);
                }
                else if (myArray[myArray.Length - 1] > myArray[myArray.Length - 2])
                {
                    Console.WriteLine("{0} is bigger than it's left.", myArray[position]);
                }
                else
                {
                    Console.WriteLine("{0} is equal to it's left.", myArray[position]);
                }
            }
            else
            {
                if (myArray[position] < myArray[position - 1])
                {
                    if (myArray[position] < myArray[position + 1])
                    {
                        Console.WriteLine("{0} is smaller than it's neighbours.", myArray[position]);
                    }
                    else if (myArray[position] == myArray[position + 1])
                    {
                        Console.WriteLine("{0} is smaller than it's left and equal to it's right.", myArray[position]);
                    }
                    else
                    {
                        Console.WriteLine("{0} is smaller than it's left and bigger than it's right.", myArray[position]);
                    }
                }
                else if (myArray[position] == myArray[position - 1])
                {
                    if (myArray[position] < myArray[position + 1])
                    {
                        Console.WriteLine("{0} is euqal to it's left and smaller than it's right.", myArray[position]);
                    }
                    else if (myArray[position] == myArray[position + 1])
                    {
                        Console.WriteLine("{0} is equal to it's neighbours.", myArray[position]);
                    }
                    else
                    {
                        Console.WriteLine("{0} is equal to it's left and bigger than it's right.", myArray[position]);
                    }
                }
                else
                {
                    if (myArray[position] < myArray[position + 1])
                    {
                        Console.WriteLine("{0} is bigger than it's left and smaller than it's right.", myArray[position]);
                    }
                    else if (myArray[position] == myArray[position + 1])
                    {
                        Console.WriteLine("{0} is bigger than it's left and equal to it's right.", myArray[position]);
                    }
                    else
                    {
                        Console.WriteLine("{0} is bigger than it's neighbours.", myArray[position]);
                    }
                }
            }
        }
    }
}