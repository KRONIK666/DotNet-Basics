using System;
using System.IO;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (StreamReader reader = new StreamReader("TestFile.txt"))
                {
                    String line = reader.ReadToEnd();
                    Console.WriteLine(line);
                }
            }
            catch (Exception a)
            {
                Console.WriteLine("The file could not be read!");
                Console.WriteLine(a.Message);
                Console.WriteLine();
            }
        }
    }
}