using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _04._1.DistanceBetweenPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] X = Console.ReadLine().Split(new[] { ' ' }).Select(int.Parse).ToArray();
            int[] Y = Console.ReadLine().Split(new[] { ' ' }).Select(int.Parse).ToArray();
            int x1 = X[0];
            int y1 = X[1];
            int x2 = Y[0];
            int y2 = Y[1];
            var point = new Point();
            double distance = point.Distance(x1, y1, x2, y2);
            Console.WriteLine($"{distance:f3}");
        }

        public class Point
        {
            public double Distance(int x1, int y1, int x2, int y2)
            {
                int X = x1 - x2;
                int Y = y1 - y2;
                double dist = Math.Sqrt(X * X + Y * Y);
                return dist;
            }
        }
    }
}
