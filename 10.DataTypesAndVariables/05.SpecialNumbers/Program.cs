using System;

namespace _05.SpecialNumbers
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                int j = i;
                int sum = 0;

                while (j != 0)
                {
                    sum += j % 10;
                    j /= 10;
                }
                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");

                }
            }
        }
    }
}
