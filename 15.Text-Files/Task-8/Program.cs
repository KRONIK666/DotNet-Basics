using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = "";

            using (StreamReader reader = new StreamReader("Text.txt"))
            {
                int counter = 0;
                string oddLine;

                while ((oddLine = reader.ReadLine()) != null)
                {
                    if (counter % 2 == 1)
                    {
                        inputText += oddLine + "\r\n";
                    } counter++;
                }
            }

            using (StreamWriter writer = new StreamWriter("Text.txt", false))
            {
                writer.Write(inputText);
            }
        }
    }
}