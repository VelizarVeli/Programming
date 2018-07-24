using System;
using System.Linq;

namespace _03._1.IntersectionOfCircles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] input2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            Circle circle1 = new Circle();
            Circle circle2 = new Circle();
            

            if (CalcDistance(input1[0], input2[0], input1[1], input2[1]) > input1[2] + input2[2])
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine("Yes");
            }
        }

       private static double CalcDistance(int x1, int x2, int y1, int y2)
        {
            int deltaX = x1 - x2;
            int deltaY = y1 - y2;

            double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
            return distance;
        }

        public class Circle
        {
            public Point Center { get; set; }
            public double Radius { get; set; }
        }

        public class Point
        {
            public int X { get; set; }
            public int Y { get; set; }
        }
    }
}
