using System;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _04._1.ClosestTwoPoints
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Point[] points = new Point[n];
            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int eks = input[0];
                int igrek = input[1];
                Point point = new Point();
                point.X = eks;
                point.Y = igrek;

                points[i] = point;
            }

            Point[] closestPoints = FindClosestPoints(points);
            foreach (Point point in closestPoints)
            {
                Console.WriteLine("({0}, {1})", point.X, point.Y);
            }
        }

        public static Point[] FindClosestPoints(Point[] points)
        {
            Point[] closest = new Point[2];
            double minDistance = Double.MaxValue;
            for (int i = 0; i < points.Length; i++)
            {
                for (int j = i + 1; j < points.Length; j++)
                {
                    int x1 = points[i].X;
                    int x2 = points[j].X;
                    int y1 = points[i].Y;
                    int y2 = points[j].Y;

                    double currentDistance = CalcDistance(x1, x2, y1, y2);
                    if (minDistance > currentDistance)
                    {
                        minDistance = currentDistance;
                        closest[0] = points[i];
                        closest[1] = points[j];
                    }
                }
            }

            Console.WriteLine($"{minDistance:f3}");
            return closest;
        }

        private static double CalcDistance(int x1, int x2, int y1, int y2)
        {
            int deltaX = x1 - x2;
            int deltaY = y1 - y2;

            double checkDistance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
            return checkDistance;
        }

        public class Point
        {
            public int X { get; set; }
            public int Y { get; set; }
        }
    }
}
