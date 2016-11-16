using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            char[] symbols = new char[2] { '-', '>' };
            string text = ".NET - Platform for applications from Microsoft.> CLR - Managed execution environment.> .NETnamespace - Hierarchical organization of classes.";

            string[] temp = text.Split(symbols);

            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = temp[i].Trim();
            }

            for (int i = 0; i < 6; i++)
            {
                dictionary.Add(temp[i], temp[i + 1]);
                i++;
            }

            for (int i = 0; i < 3; i++)
            {
                ReturnMeaning(dictionary);
            }
        }

        static void ReturnMeaning(Dictionary<string, string> dictionary)
        {
            Console.Write("Enter a word to check your Dictionary: ");
            string word = Console.ReadLine();

            foreach (var item in dictionary)
            {
                if (item.Key.Equals(word))
                {
                    Console.WriteLine("Your word means: " + item.Value);
                    Console.WriteLine();
                    break;
                }
                else if (!item.Key.Equals(word))
                {
                    continue;
                }
            }
        }
    }
}