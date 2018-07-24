using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().ToLower().Split().ToArray();
            var dict = new Dictionary<string, int>();
            foreach (var w in words)
            {
                if (dict.ContainsKey(w))
                {
                    dict[w]++;
                }
                else
                {
                    dict[w] = 1;
                }
            }
            bool first = true;
            foreach (var p in dict)
            {
                if (p.Value % 2 == 1)
                {
                    if (!first) Console.Write(", ");
                    Console.Write(p.Key);
                    first = false;
                }
            }
            Console.WriteLine();
        }
    }
}
