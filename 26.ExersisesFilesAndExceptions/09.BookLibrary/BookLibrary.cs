using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.IO;
using _09.BookLibrary;

namespace _05.Book_Library
{
    class Program
    {
        private static IEnumerable<object> libraries;

        static void Main()
        {
            var lines = File.ReadAllLines(@"..\..\input.txt");

            var books = new List<Book>();

            foreach (var line in lines)
            {
                var tokens = line.Split();

                var title = tokens[0];
                var author = tokens[1];
                var publisher = tokens[2];
                var releaseDate = DateTime.ParseExact(tokens[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                var isbn = tokens[4];
                var price = decimal.Parse(tokens[5]);

                var book = new Book()
                {
                    Title = title,
                    Author = author,
                    Publisher = publisher,
                    ReleaseDate = releaseDate,
                    ISBN = isbn,
                    Price = price
                };
                books.Add(book);
            }
            var grouped = books.GroupBy(a => a.Author);

            var libraries = grouped.Select(group => new Library()
            {
                Name = group.Key,
                Books = group.ToList()
            }).OrderByDescending(library => library.PriceSum)
            .ThenBy(a => a.Name)
            .ToArray();
            var result = new List<string>();
            foreach (var library in libraries)
            {
                result.Add($"{library.Name} -> {library.PriceSum}");
            }
            File.WriteAllLines(@"..\..\Output.txt", result);
        }
    }
}