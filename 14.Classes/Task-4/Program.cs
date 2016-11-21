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
            Console.Write("Add name of the library: ");
            string name = Console.ReadLine();
            Console.WriteLine();

            Library library = new Library(name);

            Book firstBook = new Book("C#", "Svetlin Nakov", "Halcedon", 2002, "B1690");
            Book secondBook = new Book("Scream", "Steven King", "Mistery Books", 1998, "B1800");
            Book thirdBook = new Book("Game Of Thrones", "George Martin", "Thrones", 2015, "B2100");
            Book fourthBook = new Book("Ice And Fire", "George Martin", "Thrones", 2013, "B1880");
            Book fifthBook = new Book("Fear", "Steven King", "Mistery Boks", 2000, "B1990");

            library.AddBook(firstBook);
            library.AddBook(secondBook);
            library.AddBook(thirdBook);
            library.AddBook(fourthBook);
            library.AddBook(fifthBook);
            library.DisplayAll();
            Console.WriteLine();

            string author;
            string title;

            Console.Write("Search for an author: ");
            author = Console.ReadLine();
            Console.WriteLine();

            library.SearchAuthor(author);
            library.DeleteBook(secondBook);
            library.DeleteBook(fifthBook);

            Console.Write("Search for a title: ");
            title = Console.ReadLine();
            Console.WriteLine();

            library.SearchTitle(title);
            library.DisplayAll();
            Console.WriteLine();
        }
    }
}