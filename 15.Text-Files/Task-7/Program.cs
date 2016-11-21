using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;

            using (StreamReader reader = new StreamReader("Text.txt"))
            {
                text = reader.ReadToEnd();
            }

            text = text.Replace("start", "finish");

            using (StreamWriter writer = new StreamWriter("Result.txt"))
            {
                writer.Write(text);
            }
        }
    }
}