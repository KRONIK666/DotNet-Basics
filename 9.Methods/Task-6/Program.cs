using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    class Program
    {
        static int number = int.MinValue;

        static void Main(string[] args)
        {
            Console.Write("Enter array's length: ");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int[] myArray = new int[length];

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write("Enter an element: ");
                myArray[i] = int.Parse(Console.ReadLine());
            } Console.WriteLine();

            CompareNumber(myArray);

            if (number == int.MinValue)
            {
                Console.WriteLine("There is no such number and the result is: -1");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("{0} is bigger than it's neighbours.", number);
                Console.WriteLine();
            }
        }

        public static void CompareNumber(int[] myArray)
        {
            for (int i = 1; i < myArray.Length - 1; i++)
            {
                if (myArray[i] > myArray[i - 1] && myArray[i] > myArray[i + 1])
                {
                    number = myArray[i];
                    break;
                }
            }
        }
    }
}