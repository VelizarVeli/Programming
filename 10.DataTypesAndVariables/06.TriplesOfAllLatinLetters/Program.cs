using System;

namespace _06.TriplesOfAllLatinLetters
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            char letter = 'a';
            char a1= 'a';
            char a2 = 'a';
            char a3 = 'a';

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        a1 = (char)(letter + i);
                        a2 = (char)(letter + j);
                        a3 = (char)(letter + k);
                        Console.WriteLine($"{a1}{a2}{a3}");
                    }
                }
            }
        }
    }
}
