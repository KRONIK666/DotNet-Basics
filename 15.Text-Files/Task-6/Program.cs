using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("Names.txt");
            List<string> names = new List<string>();

            using (reader)
            {
                while (reader.EndOfStream != true)
                {
                    string name = reader.ReadLine();

                    if (name != null)
                    {
                        names.Add(name);
                    }
                } names.Sort();

                StreamWriter writer = new StreamWriter("Result.txt");

                using (writer)
                {
                    foreach (string item in names)
                    {
                        writer.WriteLine(item);
                    }
                }
            }
        }
    }
}