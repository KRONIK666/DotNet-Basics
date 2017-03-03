using System;
using System.Collections.Generic;

namespace Task_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            Console.Write("Enter a text: ");
            string text = Console.ReadLine();
            Console.WriteLine();

            int counter = 0;
            char[] symbols = new char[] { ' ', ',', '.', '!', '?' };
            string[] words = text.Split(symbols);

            for (int i = 0; i < words.Length; i++)
            {
                words[i].Trim();
            }

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words.Length; j++)
                {
                    words[i] = words[i].ToLower();

                    if (words[i] == words[j])
                    {
                        counter++;
                        continue;
                    }
                }

                if (!dictionary.ContainsKey(words[i]) && words[i] != "")
                {
                    dictionary.Add(words[i], counter);
                }

                counter = 0;
            }

            SortedDictionary<string, int> sortedDictionary = new SortedDictionary<string, int>(dictionary);

            Console.WriteLine("Those words were used in your text:");
            Console.WriteLine();

            foreach (var item in sortedDictionary)
            {
                Console.WriteLine(item);
            } Console.WriteLine();
        }
    }
}