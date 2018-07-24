using System;

namespace _01.PokeMon
{
    class Program
    {
        static void Main()
        {
            uint N = uint.Parse(Console.ReadLine());
            uint M = uint.Parse(Console.ReadLine());
            byte Y = byte.Parse(Console.ReadLine());
            uint counter = 0;
            decimal fiftyCents = (decimal)N / 2;

            while (N >= M)
            {
                N -= M;
                if (N == fiftyCents)
                {
                    if (Y != 0)  //BE VERY CAREFUL WITH DIVIDING 0 OR DIVIDING WITH 0
                    {
                        N /= Y;
                    }
                }
                counter++;
            }

            Console.WriteLine(N);
            Console.WriteLine(counter);
        }
    }
}