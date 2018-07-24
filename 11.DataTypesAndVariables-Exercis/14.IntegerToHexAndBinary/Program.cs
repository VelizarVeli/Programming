using System;

namespace _14.IntegerToHexAndBinary
{
    class Program
    {
        static void Main()
        {
            int integer = int.Parse(Console.ReadLine());
            string hexValue = integer.ToString("X");
            string binary = Convert.ToString(integer, 2);
            Console.WriteLine(hexValue);
            Console.WriteLine(binary);
        }
    }
}
