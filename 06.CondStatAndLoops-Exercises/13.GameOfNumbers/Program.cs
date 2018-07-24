using System;

namespace _13.GameOfNumbers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int sum = 0;
            int counter = 0;
            int count = 0;
            int a = 0;
            int b = 0;

            for (int i = n; i <= m; i++)
            {
                for (int j = n; j <= m; j++)
                {
                    counter++;
                    if (i + j == magicNumber)
                    {
                        count++;
                        a = i;
                        b = j;
                        sum = a + b;
                    }
                }
            }
            if (sum != 0)
            {
                Console.WriteLine($"Number found! {a} + {b} = {magicNumber}");
            }
            else
                Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");
        }
    }
}
