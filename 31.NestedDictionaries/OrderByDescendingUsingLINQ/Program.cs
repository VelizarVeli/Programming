using System;
using System.Linq;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().ToArray();
            var wordsSortedByLength =
                  from word in words
                  orderby word.Length descending
                  select word;
            foreach (var word in wordsSortedByLength)
            {
                Console.WriteLine(word);
            }
        }
    }
}

