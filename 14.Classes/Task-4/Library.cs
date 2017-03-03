using System;
using System.Collections.Generic;
using System.Text;

namespace Task_4
{
    public class Library
    {
        private string bookName;
        private List<Book> books;

        public string BookName
        {
            get { return bookName; }
            set { bookName = value; }
        }

        internal List<Book> Books
        {
            get { return books; }
            set { books = value; }
        }

        public Library(string bookName)
        {
            this.bookName = bookName;
            this.books = new List<Book>();
        }

        public string AddBook(Book book)
        {
            books.Add(book);
            return "Book added.";
        }

        public string DeleteBook(Book book)
        {
            if (books.Contains(book))
            {
                books.Remove(book);
                return "Book deleted.";
            }
            else
            {
                return "Book not found.";
            }
        }

        public string SearchAuthor(string author)
        {
            StringBuilder listWithSearchedBooks = new StringBuilder();

            bool isFoundBook = false;

            foreach (Book book in books)
            {
                if (book.Author.Equals(author))
                {
                    listWithSearchedBooks.Append(book.ToString());
                    isFoundBook = true;
                }
            }

            if (isFoundBook)
            {
                return "There is a book of this author.";
            }
            else
            {
                return "Not found book of this author.";
            }
        }

        public string SearchTitle(string title)
        {
            foreach (Book book in books)
            {
                if (book.Title.Equals(title))
                {
                    return "There is a book with that title.";
                }
            } return "Not found.";
        }

        public void DisplayAll()
        {
            int count = 1;

            Console.WriteLine("{0,-3}|{1,-15}|{2,-15}", "N", "Title", "Author");

            foreach (Book book in this.books)
            {
                Console.WriteLine("{0,-3}|{1,-15}|{2,-15}", count, book.Title, book.Author);
                count++;
            }
        }
    }
}