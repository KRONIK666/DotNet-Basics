using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    public class Book
    {
        private string title;
        private string author;
        private string publisher;
        private int yearOfPublishing;
        private string isbnNumber;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public string Publisher
        {
            get { return publisher; }
            set { publisher = value; }
        }

        public int YearOfPublishing
        {
            get { return yearOfPublishing; }
            set { yearOfPublishing = value; }
        }

        public string ISBNNumber
        {
            get { return isbnNumber; }
            set { isbnNumber = value; }
        }

        public Book(string title, string author, string publisher, int yearOfPublishing, string isbnNumber)
        {
            this.title = title;
            this.author = author;
            this.publisher = publisher;
            this.yearOfPublishing = yearOfPublishing;
            this.isbnNumber = isbnNumber;
        }

        public override string ToString()
        {
            StringBuilder books = new StringBuilder();

            books.Append("Title: " + title);
            books.Append(Environment.NewLine);
            books.Append("Author: " + author);
            books.Append(Environment.NewLine);
            books.Append("Publisher: " + publisher);
            books.Append(Environment.NewLine);
            books.Append("Year of publishing: " + yearOfPublishing);
            books.Append(Environment.NewLine);
            books.AppendLine("ISBN Number: " + isbnNumber);
            return books.ToString();
        }
    }
}