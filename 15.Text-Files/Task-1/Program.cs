using System;
using System.IO;
using System.Text;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Odd lines in your text file are:");
            Console.WriteLine();

            StreamReader reader = new StreamReader("Text.txt", Encoding.GetEncoding("Windows-1251"));

            using (reader)
            {
                int line = 1;
                string text = reader.ReadLine();

                while (text != null)
                {
                    if (line % 2 != 0)
                    {
                        Console.WriteLine(text);
                    }

                    line++;
                    text = reader.ReadLine();
                }
            } Console.WriteLine();
        }
    }
}