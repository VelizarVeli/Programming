using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Snowflake
{
    class Program
    {
        static void Main()
        {
            string surface = @"^[\W\D]+$";
            string mantle = @"^[\d_]+$";
            string core = @"^([\W\D]+)([\d_]+)([a-zA-Z]+)([\d_]+)([\W\D]+)$";

            string line1 = Console.ReadLine();
            string line2 = Console.ReadLine();
            string line3 = Console.ReadLine();
            string line4 = Console.ReadLine();
            string line5 = Console.ReadLine();

            bool lin1 = false;
            bool lin2 = false;
            bool lin3 = false;
            bool lin4 = false;
            bool lin5 = false;

            Regex li1 = new Regex( surface);
            Match match1 = li1.Match(line1);
            if (match1.Success)
            {
                lin1 = true;
            }
            Regex li2 = new Regex(mantle);
            Match match2 = li2.Match(line2);
            if (match2.Success)
            {
                lin2 = true;
            }
            Regex li3 = new Regex(core);
            Match match3 = li3.Match(line3);
            if (match3.Success)
            {
                lin3 = true;
            }
            Regex li4 = new Regex(mantle);
            Match match4 = li4.Match(line4);
            if (match4.Success)
            {
                lin4 = true;
            }
            Regex li5 = new Regex(surface);
            Match match5 = li5.Match(line5);
            if (match5.Success)
            {
                lin5 = true;
            }
            if (lin1 && lin2 && lin3 && lin4 && lin5)
            {
                Console.WriteLine("Valid");
                Console.WriteLine(match3.Groups[3].Length);
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
