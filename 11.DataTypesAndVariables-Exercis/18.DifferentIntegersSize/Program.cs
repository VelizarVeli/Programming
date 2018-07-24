using System;

namespace _18.DifferentIntegersSize
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            try
            {
                long number = long.Parse(input);
                Console.WriteLine($"{number} can fit in:");
            }
            catch (OverflowException)
            {

            }
            try
            {
                sbyte number = sbyte.Parse(input);
                Console.WriteLine($"* sbyte");
            }
            catch (Exception)
            {
                
            }
            try
            {
                byte number = byte.Parse(input);
                Console.WriteLine($"* byte");
            }
            catch (Exception)
            {

            }
            try
            {
                short number = short.Parse(input);
                Console.WriteLine($"* short");
            }
            catch (Exception)
            {

            }
            try
            {
                ushort number = ushort.Parse(input);
                Console.WriteLine($"* ushort");
            }
            catch (Exception)
            {

            }
            try
            {
                int number = int.Parse(input);
                Console.WriteLine($"* int");
            }
            catch (Exception)
            {

            }
            try
            {
                uint number = uint.Parse(input);
                Console.WriteLine($"* uint");
            }
            catch (Exception)
            {

            }
            try
            {
                long number = long.Parse(input);
                Console.WriteLine($"* long");
            }
            catch (Exception)
            {
                Console.WriteLine($"{input} can't fit in any type");
            }
        }
    }
}
