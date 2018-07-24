using System;

namespace _16.ComparingFloats
{
    class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            
            const double precision = 0.000001;
            double diff = Math.Abs(a - b);
            if (diff < precision)
            {
                Console.WriteLine("True");
            }
            else Console.WriteLine("False");
        }
    }
}
