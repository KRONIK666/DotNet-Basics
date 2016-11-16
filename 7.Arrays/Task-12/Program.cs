using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            Console.Write("Enter a word: ");
            char[] word = (Console.ReadLine()).ToCharArray();
            Console.WriteLine();

            Console.Write("Indexes of letters of your word: ");

            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (word[i] == alphabet[j])
                    {
                        Console.Write("{0} ", j);
                    }
                }
            } Console.WriteLine();
            Console.WriteLine();
        }
    }
}