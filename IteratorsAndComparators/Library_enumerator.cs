using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Library_enumerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            library.Books.Add(new Book("Eminent Discovery", 2011, new List<string>() { "John Foster" }));
            library.Books.Add(new Book("Yoga teachings", 311, new List<string>() { "Rama Yama" }));
            library.Books.Add(new Book("Detektiv", 1999, new List<string>() { "Ronald Hemilton" }));
            foreach (var book in library)
            {
                Console.WriteLine($"{ book.Name}" + " " + $"{book.Year}");

            }
        }
    }
    public class Library : IEnumerable<Book>
    {
        private List<Book> books;

        public Library()
        {
            this.books = new List<Book>();
        }

        public void Add(Book book)
        {
            Books.Add(book);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            for (int currentIndex = 0; currentIndex < Books.Count; currentIndex++)
            {
                yield return this.Books[currentIndex];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public List<Book> Books
        {
            get
            {
                return this.books;
            }
            set
            {
                this.books = value;
            }
        }
    }
    public class Book
    {
        public Book(string name, int year, List<string> authors)
        {
            Name = name;
            Year = year;
            Authors = authors;
        }

        public string Name { get; set; }
        public int Year { get; set; }
        public List<string> Authors { get; set; }
    }
    public class LibraryEnumerator : IEnumerator<Book>
    {
        private int currentIndex = -1;
        private List<Book> books;

        public LibraryEnumerator(List<Book> books)
        {
            this.books = books;
        }

        public Book Current => books[currentIndex];

        object IEnumerator.Current => this.Current;

        public void Dispose()
        {
            { }
        }

        public bool MoveNext()
        {
            currentIndex++;
            if (currentIndex >= books.Count || currentIndex < 0)
            {
                return false;
            }
            else return true;
        }

        public void Reset()
        {
            currentIndex = -1;
        }
    }
}
