using System;

namespace _11.GeometryCalculator
{
    class Program
    {
        static double CalculatingTriangleArea(double side, double height)
        {
            double area = (side * height) / 2;
            return area;
        }
        static double CalculatingSquareArea(double side)
        {
            double area = side * side;
            return area;
        }
        static double CalculatingRectangleArea(double width, double height)
        {
            double area = width * height;
            return area;
        }
        static double CalculatingCircleArea(double radius)
        {
            double area = Math.PI * radius * radius;
            return area;
        }

        static void Main()
        {
            string figType = Console.ReadLine();
            if (figType == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                double area = CalculatingTriangleArea(side, height);
                Console.WriteLine($"{area:f2}");
            }
            else if (figType == "square")
            {
                double side = double.Parse(Console.ReadLine());
                double area = CalculatingSquareArea(side);
                Console.WriteLine($"{area:f2}");
            }
            else if (figType == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                double area = CalculatingRectangleArea(width, height);
                Console.WriteLine($"{area:f2}");
            }
            else if (figType == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double area = CalculatingCircleArea(radius);
                Console.WriteLine($"{area:f2}");
            }
        }
    }
}
