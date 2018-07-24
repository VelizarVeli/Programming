using System;
// решена втори път за време 35 минути 100/100
namespace _01._1.Again
{
    class Program
    {
        static void Main()
        {
            long N = long.Parse(Console.ReadLine());
            long M = long.Parse(Console.ReadLine());
            long Y = long.Parse(Console.ReadLine());
            decimal fiftyCents = (decimal)N / 2;

            int targetsPoked = 0;

            while (N >= M)
            {
                targetsPoked++;
                N -= M;
                if (N == fiftyCents)
                {
                    if (Y != 0 && N != 0)
                    {
                        N /= Y;
                    }
                }
            }
            Console.WriteLine(N);
            Console.WriteLine(targetsPoked);
        }
    }
}
