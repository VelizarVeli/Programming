using System;

namespace _09.MakeAWord
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string word = "";
            for (int i = 0; i < n; i++)
            {
                string cha = Console.ReadLine();
                word += cha;
            }
            Console.WriteLine($"The word is: {word}");
        }
    }
}
