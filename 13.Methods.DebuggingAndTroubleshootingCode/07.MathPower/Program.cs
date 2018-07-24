using System;

namespace _07.MathPower
{
    class Program
    {
        static double RaiseToPower(double number, int power)
        {
            double result = 1;
            for (int i = 1; i <= power; i++)
            {
                result *= number;
            }
            return result;
        }
        static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            double powered = RaiseToPower(number, power);
            Console.WriteLine(powered);
        }
    }
}
