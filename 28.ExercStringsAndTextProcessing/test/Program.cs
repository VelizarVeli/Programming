using System;

namespace _09.MelrahShake
{
    class Program
    {
        static void Main(string[] args)
        {
            string characters = Console.ReadLine();
            string pattern = Console.ReadLine();
            while (characters.IndexOf(pattern) != -1 && characters.LastIndexOf(pattern) != -1)
            {

                int patLength = pattern.Length;
                int first = characters.IndexOf(pattern);
                int last = characters.LastIndexOf(pattern);
                characters = characters.Remove(last, patLength);
                characters = characters.Remove(first, patLength);
                Console.WriteLine("Shaked it.");
                pattern = pattern.Remove(pattern.Length / 2, 1);
                var patternIsEmpty = pattern != string.Empty;
            }
            Console.WriteLine("No shake.");
            Console.WriteLine(characters);
        }
    }
}
