using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";

            int firstIndex = 0;
            int secondIndex = 0;

            while (firstIndex < text.LastIndexOf("<upcase>"))
            {
                firstIndex = text.IndexOf("<upcase>", firstIndex + 1);
                secondIndex = text.IndexOf("</upcase>", secondIndex + 1);

                string upCase = text.Substring(firstIndex + 8, secondIndex - firstIndex - 8).ToUpper();
                string toReplace = text.Substring(firstIndex, secondIndex - firstIndex + 9);
                text = text.Replace(toReplace, upCase);
            }

            Console.WriteLine("The new text is: " + text);
            Console.WriteLine();
        }
    }
}