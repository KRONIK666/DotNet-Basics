using System;

namespace Task_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a list of words, separated with comas: ");
            string list = Console.ReadLine();
            Console.WriteLine();

            string[] words = list.Split(',');

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].Trim();
            }

            Array.Sort<string>(words);

            Console.WriteLine("Sorted alphabetically:");
            Console.WriteLine();

            foreach (var item in words)
            {
                Console.WriteLine(item);
            } Console.WriteLine();
        }
    }
}