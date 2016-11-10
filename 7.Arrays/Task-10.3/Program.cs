using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size of Matrix: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int[,] myArray = new int[n, n];

            int counter = 1;
            myArray[n - 1, 0] = 1;

            for (int row = n - 2; row >= 0; row--)
            {
                int newRow = row;
                myArray[row, 0] = myArray[row + 1, 0] + counter;

                for (int diagonal = 1; diagonal <= counter; diagonal++)
                {
                    myArray[newRow + 1, diagonal] = myArray[newRow, diagonal - 1] + 1;
                    newRow++;
                } counter++;
            }

            int diagonalLength = 2;
            int posX = 1;
            int posY = n - 1;
            int prevX = 0;
            int prevY = n - 1;
            myArray[0, n - 1] = n * n;

            for (int i = 1; i < counter - 1; i++)
            {
                for (int j = 1; j <= diagonalLength; j++)
                {
                    myArray[posX, posY] = myArray[prevX, prevY] - 1;
                    prevX = posX;
                    prevY = posY;
                    posX--;
                    posY--;
                }

                diagonalLength++;
                posX = i + 1;
                posY = n - 1;
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