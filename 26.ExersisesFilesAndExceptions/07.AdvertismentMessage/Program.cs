using System;
using System.IO;
using System.Text;

namespace _02.Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            var random = new Random();
            var phrases = File.ReadAllLines(@"..\..\phrases.txt");
            var events = File.ReadAllLines(@"..\..\events.txt");
            var authors = File.ReadAllLines(@"..\..\authors.txt");
            var cities = File.ReadAllLines(@"..\..\cities.txt");

            var numberOfMessages = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfMessages; i++)
            {
                var randomPhrase = phrases[random.Next(phrases.Length)];
                var randomEvents = events[random.Next(events.Length)];
                var randomAuthors = authors[random.Next(authors.Length)];
                var randomCities = cities[random.Next(cities.Length)];

                Console.WriteLine($"{randomPhrase} {randomEvents} {randomAuthors} - {randomCities}");
            }
        }
    }
}