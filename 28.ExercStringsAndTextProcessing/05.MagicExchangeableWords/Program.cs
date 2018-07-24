using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.MagicExchangeableWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var strings = Console.ReadLine().Split().Select(a => a.ToCharArray().Distinct().ToArray()).ToArray();
            var firsLength = strings.First().Length;
            Console.WriteLine(strings.All(a => a.Length == firsLength).ToString().ToLower());
        }
    }
}
