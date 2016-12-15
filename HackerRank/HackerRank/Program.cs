using System;
using System.Collections.Generic;

namespace HackerRank
{
    internal class Program
    {
        public static List<int> base2 = new List<int>();

        private static void Main()
        {
            var title = Console.ReadLine();
            var author = Console.ReadLine();
            var price = int.Parse(Console.ReadLine());
            Book new_novel = new MyBook(title, author, price);
            new_novel.display();
        }

        internal abstract class Book
        {
            protected string title;
            protected string author;

            public Book(string t, string a)
            {
                title = t;
                author = a;
            }

            public abstract void display();
        }

        private class MyBook : Book
        {
            private readonly string _title;
            private readonly string _author;
            private readonly int _price;

            public MyBook(string title, string author, int price) : base(title, author)
            {
                _title = title;
                _author = author;
                _price = price;
            }

            public override void display()
            {
                Console.WriteLine("Title: " + _title);
                Console.WriteLine("Author: " + _author);
                Console.WriteLine("Price: " + _price);
            }
        }
    }
}