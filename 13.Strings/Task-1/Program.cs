using System;
using System.Text;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "reptile";

            StringBuilder result = new StringBuilder();

            for (int i = word.Length - 1; i >= 0; i--)
            {
                result.Append(word[i]);
            }

            Console.WriteLine("The word reversed: " + result);
            Console.WriteLine();
        }
    }
}