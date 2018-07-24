using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NewGrocery
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"^[A-Z][a-z]+:\d+\.\d{2}$");

            string input = Console.ReadLine();
            Dictionary<string, double> Products = new Dictionary<string, double>();
            while (input != "bill")
            {

                if (regex.IsMatch(input))
                {
                    string[] Tokens = input.Split(':');
                    if (!Products.ContainsKey(Tokens[0]))
                    {
                        Products.Add(Tokens[0], double.Parse(Tokens[1]));
                    }
                    else
                    {
                        Products[Tokens[0]] = double.Parse(Tokens[1]);
                    }
                }

                input = Console.ReadLine();
            }
            foreach (var p in Products.OrderByDescending(x => x.Value))
            {
                Console.WriteLine("{0} costs {1:0.00}", p.Key, p.Value);
            }
        }
    }
}