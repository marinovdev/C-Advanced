using System;

namespace operator-keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Bible", 1300, 100);
            Book book2 = new Book("New age bulshit", 240, 2000);
            if(book1 < book2)
            {
                Console.WriteLine("book2 is bigger");
            }
        }
    }

    class Book : IComparable<Book>
    {
        private string name;
        private int pages;
        private int year;

        public Book(string name, int pages, int year)
        {
            this.Name = name;
            this.Year = year;
            this.Pages = pages;
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public int Pages
        {
            get { return pages; }
            set { pages = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int CompareTo(Book other)
        {
            if (this.Year > other.Year) return 1;
            else if (this.Year < other.Year) return -1;
            return 0;
        }

        public static bool operator <(Book book1, Book book2)
        {
            return book1.CompareTo(book2) < 0;
        }
        public static bool operator >(Book book1, Book book2)
        {
            return book1.CompareTo(book2) > 0;
        }
    }
}
