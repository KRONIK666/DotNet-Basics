using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("Matrix.txt");

            using (reader)
            {
                string elements = reader.ReadLine();
                int n = int.Parse(elements);
                int[,] matrix = new int[n, n];
                elements = reader.ReadLine();

                while (elements != null)
                {
                    string[] numbers;

                    for (int row = 0; row < n; row++)
                    {
                        numbers = elements.Split(' ');

                        for (int col = 0; col < n; col++)
                        {
                            matrix[row, col] = int.Parse(numbers[col]);
                        } elements = reader.ReadLine();
                    }
                }

                int bestSum = int.MinValue;

                for (int row = 0; row < matrix.GetLength(0) - 1; row++)
                {
                    for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                    {
                        int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];

                        if (sum > bestSum)
                        {
                            bestSum = sum;
                        }
                    }
                }

                StreamWriter result = new StreamWriter("Result.txt");

                using (result)
                {
                    result.Write("Best sum is: " + bestSum.ToString());
                }
            }
        }
    }
}