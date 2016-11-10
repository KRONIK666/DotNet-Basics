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
            Console.Write("Enter array's length: ");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int[] myArray = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter {0} element: ", i + 1);
                myArray[i] = int.Parse(Console.ReadLine());
            } Console.WriteLine();

            Console.Write("Enter sum: ");
            int sum = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < myArray.Length; i++)
            {
                int first = myArray[i];

                for (int j = i + 1; j < myArray.Length; j++)
                {
                    int second = myArray[j];

                    if ((first + second) == sum)
                    {
                        Console.WriteLine("Sum is possible with elements: ({0}, {1}) ", first, second);
                    }
                    else
                    {
                        Console.WriteLine("Sum is not possible!");
                        break;
                    }
                }
            } Console.WriteLine();
        }
    }
}