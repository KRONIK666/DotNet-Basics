using System;

namespace Task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "C# is not C++ and PHP is not Delphi";
            string finalText = "";

            string[] words = text.Split(' ');
            string[] newText = new string[words.Length];

            for (int i = words.Length - 1; i >= 0; i--)
            {
                newText[words.Length - i - 1] = words[i];
            }

            for (int i = 0; i < newText.Length; i++)
            {
                finalText = finalText + newText[i] + " ";
            }

            finalText = finalText.TrimEnd();

            Console.WriteLine("Your text reversed is: " + finalText);
            Console.WriteLine();
        }
    }
}