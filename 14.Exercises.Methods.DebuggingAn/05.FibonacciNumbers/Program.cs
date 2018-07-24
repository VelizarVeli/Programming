using System;

namespace _05.FibonacciNumbers
{
    class Program
    {
        static int CalculateFibonacci(int n)
        {
            int num = 1;
            int num1 = 1;
            if (n < 2)
            {
                return num;
            }
            int num2 = num + num1;
            for (int i = 2; i < n; i++)
            {
                num = num1;
                num1 = num2;
                num2 = num1 + num;
            }
            return num2;
        }

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int num2 = CalculateFibonacci(n);
            Console.WriteLine(num2);
        }
    }
}
