using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Regex.Split(Console.ReadLine(), @"\W+");
            Console.WriteLine(string.Join("\r\n", tokens));
        }
    }
}
