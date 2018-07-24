using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03._2.Trainegram20August2017
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            while (input != "Traincode!")
            {
                Regex locomotive = new Regex(@"^<\[[^a-zA-Z0-9]*\]\.");
                Match lengthy = locomotive.Match(input);
                int length = lengthy.Length;
                string wagons = input.Substring(length);
                Regex wagonsy = new Regex(@"^[\.\[\w\]\.]+$");
                Match wagy = wagonsy.Match(wagons);
                if (length > 0)
                {
                    Console.WriteLine(input);
                }
                else if (wagy.Success)
                {
                    Console.WriteLine(input);
                }
                input = Console.ReadLine();
            }
        }
    }
}
