using System;

namespace _02._1.RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Random rnd = new Random();
            for (int i = 0; i < words.Length - 1; i++)
            {
                string currentWord = words[i];
                int randomDigit = rnd.Next(i, words.Length);
                words[i] = words[randomDigit];
                words[randomDigit] = currentWord;
            }

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
