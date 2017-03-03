using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Standart playing cards:");
            Console.WriteLine();

            for (int i = 2; i <= 14; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    string color = "of Spades";

                    if (j == 2)
                    {
                        color = "of Hearts";
                    }
                    else if (j == 3)
                    {
                        color = "of Diamonds";
                    }
                    else if (j == 4)
                    {
                        color = "of Clubs";
                    }

                    string J = "Jack";
                    string Q = "Queen";
                    string K = "King";
                    string A = "Ace";

                    if (i <= 10)
                    {
                        Console.WriteLine(i + " " + color);
                    }
                    else if (i == 11)
                    {
                        Console.WriteLine(J + " " + color);
                    }
                    else if (i == 12)
                    {
                        Console.WriteLine(Q + " " + color);
                    }
                    else if (i == 13)
                    {
                        Console.WriteLine(K + " " + color);
                    }
                    else if (i == 14)
                    {
                        Console.WriteLine(A + " " + color);
                    }
                }
            } Console.WriteLine();
        }
    }
}