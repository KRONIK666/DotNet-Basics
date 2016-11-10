using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] laudatoryPhrases = new string[] {"Продуктът е отличен.", "Това е страхотен продукт.", "Постоянно ползвам този продукт.", "Това е най-добрият продукт от тази категория."};
            string[] laudatoryStories = new string[] {"Вече се чувствам добре.", "Успях да се променя.", "Той направи чудо.", "Не мога да повярвам, но вече се чувствам страхотно.",
                "Опитайте и вие. Аз съм много доволна."};
            string[] firstName = new string[] {"Диана", "Петя", "Стела", "Елена", "Катя"};
            string[] familyName = new string[] {"Иванова", "Петрова", "Кирова"};
            string[] cities = new string[] {"София", "Пловдив", "Варна", "Русе", "Бургас"};

            Random commercial = new Random();

            Console.WriteLine("{0} {1} - Казвам се {2} {3} и съм от {4}.", laudatoryPhrases[commercial.Next(4)], laudatoryStories[commercial.Next(5)], firstName[commercial.Next(5)],
                familyName[commercial.Next(3)], cities[commercial.Next(5)]);
            Console.WriteLine();
        }
    }
}