using System;

namespace _05.WordInPlural
{
    class Program
    {
        static void Main()
        {
            string word = Console.ReadLine();

            if (word.EndsWith("y"))
            {
                word = word.Remove(word.Length - 1);

                Console.WriteLine(word + "ies");
            }

            else if (word.EndsWith("ch") || word.EndsWith("sh") || word.EndsWith("o") || word.EndsWith("s") || word.EndsWith("x") || word.EndsWith("z"))
            {
                Console.WriteLine(word + "es");
            }
            else
            {
                Console.WriteLine(word + "s");
            }
        }
    }
}
