using System;

namespace _06.IntervalOfNumbers
{
    class Program
    {
        static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                var num = num2;
                num2 = num1;
                num1 = num;
            }
            for (int i = num1; i <= num2; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
