namespace _10_BookLibraryMod
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;
    using _10_BookLibraryMod.Classes;
    using System.Globalization;

    public class StartUp
    {
        public static void Main()
        {
            var input = File.ReadAllLines(@"..\..\Input.txt");
            var library = AddBooks(input);
            int indexer = 0;
            int booksNumber = int.Parse(input[indexer++]);

            var specificDate = DateTime.ParseExact(input[input.Length - 1],
                "dd.MM.yyyy", CultureInfo.InvariantCulture);


            var titlesAfterDate = new Dictionary<string, DateTime>();

            foreach (var book in library.Books)
            {
                if (!titlesAfterDate.ContainsKey(book.Title) && book.ReleaseDate > specificDate)
                {
                    titlesAfterDate[book.Title] = book.ReleaseDate;
                }
            }

            var result = titlesAfterDate
                .OrderBy(p => p.Value)
                .ThenBy(a => a.Key)
                .ToArray();

            var output = new List<string>();

            foreach (var title in result)
            {
                output.Add($"{title.Key} -> {title.Value:dd.MM.yyy}");
            }
            File.WriteAllLines(@"..\..\Output.txt", output);
        }

        public static Library AddBooks(string[] input)
        {
            var library = new Library
            {
                Name = "Slaweykow",
                Books = new List<Book>()
            };

            int indexer = 0;
            int booksNumber = int.Parse(input[indexer++]);

            for (int i = 0; i < booksNumber; i++)
            {
                string[] informationArray = input[indexer++]
                    .Split(' ')
                    .ToArray();

                var book = new Book
                {
                    Title = informationArray[0],
                    Author = informationArray[1],
                    Publisher = informationArray[2],
                    ReleaseDate = DateTime
                        .ParseExact(informationArray[3]
                            , "dd.MM.yyyy", CultureInfo.InvariantCulture),
                    ISBN = informationArray[4],
                    Price = decimal.Parse(informationArray[5])
                };

                library.Books.Add(book);
            }
            return library;
        }
    }
}