using System.IO;
using System.Text;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("Text.txt", Encoding.GetEncoding("Windows-1251"));
            StreamWriter writer = new StreamWriter("Result.txt", false, Encoding.GetEncoding("Windows-1251"));

            using (reader)
            {
                int line = 1;
                string text = reader.ReadLine();

                while (text != null)
                {
                    writer.WriteLine("Line {0} - {1}", line, text);

                    line++;
                    text = reader.ReadLine();
                } writer.Close();
            }
        }
    }
}