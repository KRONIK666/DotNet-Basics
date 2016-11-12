using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";

            int index1 = 0;
            int index2 = 0;
            int index3 = 0;
            int index4 = 0;

            index1 = text.IndexOf("<upcase>");
            index2 = text.IndexOf("</upcase>");
            index3 = text.LastIndexOf("<upcase>");
            index4 = text.LastIndexOf("</upcase>");
        }
    }
}