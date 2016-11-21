using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader file1 = new StreamReader("File 1.txt", Encoding.GetEncoding("Windows-1251"));
            StreamReader file2 = new StreamReader("File 2.txt", Encoding.GetEncoding("Windows-1251"));
            StreamWriter result = new StreamWriter("Result.txt", false);

            using (file1)
            {
                string text1 = file1.ReadToEnd();

                using (result)
                {
                    result.WriteLine(text1);

                    using (file2)
                    {
                        string text = file2.ReadToEnd();

                        using (result)
                        {
                            result.Write(text);
                        }
                    }
                }
            }
        }
    }
}