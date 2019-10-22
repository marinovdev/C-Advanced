using System;
using System.Collections.Generic;

namespace comparer_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var book1 = new Book("Bible", 1300, 100, 5.99m);
            var book2 = new Book("Main kampf", 450, 1933, 51.90m);
            var byprice = new ComparerByPrice();
            var result = byprice.Compare(book1, book2);
            Console.WriteLine(result); // - 1
        }
    }

    class ComparerByPrice : IComparer<Book>
    {
        public int Compare(Book book1, Book book2)
        {
            if (book1.Price > book2.Price) return 1;
            if (book1.Price < book2.Price) return -1;
            return 0;
        }
    }
    class Book : IComparable<Book>
    {
        private string name;
        private int pages;
        private int year;
        private decimal price;

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }


        public Book(string name, int pages, int year)
        {
            this.Name = name;
            this.Year = year;
            this.Pages = pages;
        }

        public Book(string name, int pages, int year, decimal price)
        {
            this.name = name;
            this.pages = pages;
            this.year = year;
            this.price = price;
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
