using System;

namespace _02.MaxMEthod
{
    class Program
    {
        static int GetMax(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else return b;
        }

        static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int bigger = GetMax(num1, num2);
            int evenBigger = GetMax(bigger, num3);
            Console.WriteLine(evenBigger);
        }
    }
}
