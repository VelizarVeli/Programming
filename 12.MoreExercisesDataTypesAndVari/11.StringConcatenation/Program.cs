using System;

namespace _11.StringConcatenation
{
    class Program
    {
        static void Main()
        {
            char delimeter = char.Parse(Console.ReadLine());
            string evenOdd = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string word = "";

            for (int i = 1; i <= n; i++)
            {
                string word1 = Console.ReadLine();

                if ((evenOdd == "odd" && i % 2 == 1 && i == n) || (evenOdd == "odd" && i % 2 == 1 && i == n - 1))
                {
                    word += word1;

                }
                else if (evenOdd == "odd" && i % 2 == 1)
                {
                    word += word1 + delimeter;
                }
                if ((evenOdd == "even" && i % 2 == 0 && i == n - 1) || (evenOdd == "even" && i % 2 == 0 && i == n))
                {
                    word += word1;

                }
                else if (evenOdd == "even" && i % 2 == 0)
                {
                    word += word1 + delimeter;
                }
            }
            Console.WriteLine(word);
        }
    }
}