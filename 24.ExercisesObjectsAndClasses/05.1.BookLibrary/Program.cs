using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _05._1.BookLibrary
{
    class Program
    {
        static void Main()
        {
            Library library = new Library { Name = "Library", Books = new List<Book>() };

            Dictionary<string, decimal> authorPrice = new Dictionary<string, decimal>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                Book book = CreateBook(input);
                library.Books.Add(book);
            }

            foreach (var book in library.Books)
            {
                if (!authorPrice.ContainsKey(book.Author))
                {
                    authorPrice.Add(book.Author, book.Price);
                }
                else
                {
                    authorPrice[book.Author] += book.Price;
                }
            }

            foreach (var author in authorPrice.OrderByDescending(a => a.Value).ThenBy(a => a.Key))
            {
                Console.WriteLine($"{author.Key} -> {author.Value:f2}");
            }
        }

        private static Book CreateBook(string[] input)
        {
            Book book = new Book();
            book.Title = input[0];
            book.Author = input[1];
            book.Publisher = input[2];
            book.ReleaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
            book.ISBNNumber = int.Parse(input[4]);
            book.Price = decimal.Parse(input[5]);

            return book;
        }

        public class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public string Publisher { get; set; }
            public DateTime ReleaseDate { get; set; }
            public int ISBNNumber { get; set; }
            public decimal Price { get; set; }


        }

        public class Library
        {
            public string Name { get; set; }
            public List<Book> Books { get; set; }
        }
    }
}
