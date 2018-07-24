using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SortTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> time = Console.ReadLine().Split(' ').OrderBy(t => t).ToList();
            Console.WriteLine(string.Join(", ",time));
        }
    }
}
