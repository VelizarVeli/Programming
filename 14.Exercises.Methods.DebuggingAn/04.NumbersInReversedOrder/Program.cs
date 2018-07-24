using System;

namespace _4.NumbersInReversedOrder
{
    class Program
    {
        static void ReverseString(string number)
        {
            
            for (int i = number.Length - 1; i >= 0; i--)
            {
                Console.Write(number[i]);
            }
            Console.WriteLine();
        }

        static void Main()
        {
            string number = Console.ReadLine();
            ReverseString(number);
        }
    }
}
