using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat firstCat = new Cat();
            firstCat.Name = "Tony";
            firstCat.Color = "white";
            Cat secondCat = new Cat("Pepy", "gray");
            Cat thirdCat = new Cat("Sylvester", "black");

            Console.WriteLine("Cat " + Sequence.NextValue());
            Console.WriteLine("Cat {0} is {1}.", firstCat.Name, firstCat.Color);
            firstCat.SayMeaw();
            Console.WriteLine();

            Console.WriteLine("Cat " + Sequence.NextValue());
            Console.WriteLine("Cat {0} is {1}.", secondCat.Name, secondCat.Color);
            secondCat.SayMeaw();
            Console.WriteLine();

            Console.WriteLine("Cat " + Sequence.NextValue());
            Console.WriteLine("Cat {0} is {1}.", thirdCat.Name, thirdCat.Color);
            thirdCat.SayMeaw();
            Console.WriteLine();
        }
    }
}