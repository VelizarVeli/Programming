using System;

namespace _08.CenterPoint
{
    class Program
    {
        static double FindClosest (double x1, double y1, double x2, double y2)
        {
            double point1 = Math.Abs(x1 * x1 + y1 * y1);
            double point2 = Math.Abs(x2 * x2 + y2 * y2);
            if (point1 < point2)
            {
                return x1;
            }
            else
                return x2;
        }

        static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());

            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double closest = FindClosest(x1, y1, x2, y2);
           if(closest == x1)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
           else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }
    }
}
