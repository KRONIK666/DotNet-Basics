using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size of Matrix: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int[,] myArray = new int[n, n];

            myArray[0, 0] = 1;

            for (int i = 1; i < myArray.GetLength(0); i++)
            {
                if (i % 2 == 1)
                {
                    myArray[0, i] = myArray[0, i - 1] + (n * 2) - 1;
                }
                else
                {
                    myArray[0, i] = myArray[0, i - 1] + 1;
                }
            }

            for (int i = 1; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    if (j % 2 == 1)
                    {
                        myArray[i, j] = myArray[i - 1, j] - 1;
                    }
                    else
                    {
                        myArray[i, j] = myArray[i - 1, j] + 1;
                    }
                }
            }

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.Write("{0, 4}", myArray[i, j]);
                } Console.WriteLine();
            } Console.WriteLine();
        }
    }
}