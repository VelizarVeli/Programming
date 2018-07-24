using System;

namespace _09.LongerLine
{
    class Program
    {
        static bool CalculatingAndComparingLines(double x1Line1, double y1Line1, double x2Line1, double y2Line1, double x1Line2, double y1Line2,
            double x2Line2, double y2Line2)
        {

            double width1 = x1Line1 - x2Line1;
            double height1 = y1Line1 - y2Line1;
            double line1Length = width1 * width1 + height1 * height1;

            double width2 = x1Line2 - x2Line2;
            double height2 = y1Line2 - y2Line2;
            double line2Length = width2 * width2 + height2 * height2;

           if(line1Length >= line2Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static double FindClosest(double x1, double y1, double x2, double y2)
        {
            double point1 = Math.Abs(x1 * x1 + y1 * y1);
            double point2 = Math.Abs(x2 * x2 + y2 * y2);
            if (point1 <= point2)
            {
                return x1;
            }
            else
                return x2;
        }

        static void Main()
        {
            double x1Line1 = double.Parse(Console.ReadLine());
            double y1Line1 = double.Parse(Console.ReadLine());
            double x2Line1 = double.Parse(Console.ReadLine());
            double y2Line1 = double.Parse(Console.ReadLine());
            double x1Line2 = double.Parse(Console.ReadLine());
            double y1Line2 = double.Parse(Console.ReadLine());
            double x2Line2 = double.Parse(Console.ReadLine());
            double y2Line2 = double.Parse(Console.ReadLine());

            bool longer = CalculatingAndComparingLines(x1Line1, y1Line1, x2Line1, y2Line1, x1Line2, y1Line2, x2Line2, y2Line2);
            if(longer)
            {
                double closest = FindClosest(x1Line1, y1Line1, x2Line1, y2Line1);
                if(closest == x1Line1)
                {
                    Console.WriteLine($"({x1Line1}, {y1Line1})({x2Line1}, {y2Line1})");
                }
                else
                {
                    Console.WriteLine($"({x2Line1}, {y2Line1})({x1Line1}, {y1Line1})");

                }
            }
            else
            {
                double closest = FindClosest(x1Line2, y1Line2, x2Line2, y2Line2);
                if (closest == x1Line2)
                {
                    Console.WriteLine($"({x1Line2}, {y1Line2})({x2Line2}, {y2Line2})");
                }
                else
                {
                    Console.WriteLine($"({x2Line2}, {y2Line2})({x1Line2}, {y1Line2})");

                }
            }
        }
    }
}
