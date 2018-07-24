using System;

namespace _13.DecryptingMessages
{
    class Program
    {
        static void Main()
        {
            int key = int.Parse(Console.ReadLine());
            byte lines = byte.Parse(Console.ReadLine());
            string word = "";
            for (int i = 0; i < lines; i++)
            {
                char character = char.Parse(Console.ReadLine());
                character += (char)key;
                word += character;
            }
            Console.WriteLine(word);
        }
    }
}
