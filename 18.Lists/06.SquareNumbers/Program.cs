using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SquareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            List<double> squares = new List<double>();

            foreach (double num in numbers)
            {
                if (Math.Sqrt(num) == (int)Math.Sqrt(num))
                {
                    squares.Add(num);
                }
            }
            squares.Sort((a, b) => b.CompareTo(a));
            Console.WriteLine(string.Join(" ",squares));
        }
    }
}
