using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.HornetWings
{
    class Program
    {
        static void Main(string[] args)
        {
            long N = long.Parse(Console.ReadLine());
            decimal M = decimal.Parse(Console.ReadLine());
            long P = long.Parse(Console.ReadLine());
            decimal distance = (N / 1000) * M;
            Console.WriteLine($"{distance:f2} m.");
            decimal seconds = (N / 100);
            decimal secondsTotal = ((N / P) * 5) + seconds;
            Console.WriteLine($"{secondsTotal} s.");
        }
    }
}
