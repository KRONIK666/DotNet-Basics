using System;

namespace Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string stars1 = "";
            string stars2 = "";
            string stars3 = "";

            string text = "Microsoft announced its next generation C# compiler today. It uses advanced parser and special optimizer for the Microsoft CLR.";
            string forbiddenWords = "C#,CLR,Microsoft";

            string[] forbiddenArray = forbiddenWords.Split(',');

            for (int i = 0; i < forbiddenArray.Length; i++)
            {
                foreach (var item in forbiddenArray[i])
                {
                    if (i == 0)
                    {
                        stars1 = stars1 + "*";
                    }
                    else if (i == 1)
                    {
                        stars2 = stars2 + "*";
                    }
                    else if (i == 2)
                    {
                        stars3 = stars3 + "*";
                    }
                }
            }

            for (int i = 0; i < forbiddenArray.Length; i++)
            {
                if (text.Contains(forbiddenArray[i]) && i == 0)
                {
                    text = text.Replace(forbiddenArray[i], stars1);
                }
                else if (text.Contains(forbiddenArray[i]) && i == 1)
                {
                    text = text.Replace(forbiddenArray[i], stars2);
                }
                else if (text.Contains(forbiddenArray[i]) && i == 2)
                {
                    text = text.Replace(forbiddenArray[i], stars3);
                }
            }

            Console.WriteLine("Coded text: " + text);
            Console.WriteLine();
        }
    }
}