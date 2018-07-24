using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstLineX1 = double.Parse(Console.ReadLine());
            double firstLineY1 = double.Parse(Console.ReadLine());
            double firstLineX2 = double.Parse(Console.ReadLine());
            double firstLineY2 = double.Parse(Console.ReadLine());
            double secondLineX1 = double.Parse(Console.ReadLine());
            double secondLineY1 = double.Parse(Console.ReadLine());
            double secondLineX2 = double.Parse(Console.ReadLine());
            double secondLineY2 = double.Parse(Console.ReadLine());


            LongerLine(firstLineX1, firstLineX2, firstLineY1, firstLineY2, secondLineX1, secondLineX2, secondLineY1, secondLineY2);
        }

        static void LongerLine(double firstLineX1, double firstLineX2, double firstLineY1, double firstLineY2, double secondLineX1, double secondLineX2, double secondLineY1, double secondLineY2)
        {
            double firstLineLenght = Math.Abs(Math.Abs(firstLineX1 * firstLineY2) - Math.Abs(firstLineX2 * firstLineY1));
            double secondLineLenght = Math.Abs(Math.Abs(secondLineX1 * secondLineY2) - Math.Abs(secondLineX2 * secondLineY1));
            if (firstLineLenght >= secondLineLenght)
            {
                ClosestPoint(firstLineX1, firstLineX2, firstLineY1, firstLineY2);
            }
            else
            {
                ClosestPoint(secondLineX1, secondLineX2, secondLineY1, secondLineY2);
            }
        }
        static void ClosestPoint(double x1, double x2, double y1, double y2)
        {
            double distanceFirstPoint = (Math.Abs(x1 * x1) + Math.Abs(x2 * x2));
            double distanceSecondPoint = (Math.Abs(y1 * y1) + Math.Abs(y2 * y2));

            if (distanceFirstPoint <= distanceSecondPoint)
                Console.WriteLine("({0}, {1})({2}, {3})", x1, y1, x2, y2);
            else
                Console.WriteLine("({0}, {1})({2}, {3})", x2, y2, x1, y1);

        }
    }
}