using System;
using System.IO;
using System.Text;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader1 = new StreamReader("Text 1.txt", Encoding.GetEncoding("Windows-1251"));
            StreamReader reader2 = new StreamReader("Text 2.txt", Encoding.GetEncoding("Windows-1251"));

            using (reader1)
            using (reader2)
            {
                int equalLines = 0;
                int differentLines = 0;
                string text1 = reader1.ReadLine();
                string text2 = reader2.ReadLine();

                while (text1 != null)
                {
                    if (text1.Equals(text2))
                    {
                        equalLines++;
                    }
                    else
                    {
                        differentLines++;
                    }

                    text1 = reader1.ReadLine();
                    text2 = reader2.ReadLine();
                }

                Console.WriteLine("Equal lines in both texts: " + equalLines);
                Console.WriteLine("Different lines in both texts: " + differentLines);
                Console.WriteLine();
            }
        }
    }
}