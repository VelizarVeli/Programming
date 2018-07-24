using System;

namespace _10.CubeProperties
{
    class Program
    {
        static double CalculateFaceDiagonalsOfCube(double a)
        {
            double face = Math.Sqrt(2 * a * a);
            Console.WriteLine($"{face:f2}");
            return face;
        }
        static double CalculateSpaceOfCube(double a)
        {
            double spaceDiagonals = Math.Sqrt(3 * a * a);
            Console.WriteLine($"{spaceDiagonals:f2}");
            return spaceDiagonals;
        }
        static decimal CalculateVolumeOfCube(decimal a)
        {
            decimal volume = a * a * a;
            Console.WriteLine($"{volume:f2}");
            return volume;
        }
        static decimal CalculateAreaOfCube(decimal a)
        {
            decimal area = 6 * a * a;
            Console.WriteLine($"{area:f2}");
            return area;
        }

        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            string property = Console.ReadLine().ToLower();

            if (property == "face")
            {
                CalculateFaceDiagonalsOfCube(a);
            }
            else if (property == "space")
            {
                CalculateSpaceOfCube(a);
            }
            else if (property == "volume")
            {
                CalculateVolumeOfCube((decimal)a);
            }
            else if (property == "area")
            {
                CalculateAreaOfCube((decimal)a);
            }
        }
    }
}
