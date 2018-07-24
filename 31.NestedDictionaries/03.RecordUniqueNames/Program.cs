using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.RecordUniqueNames
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> names = new HashSet<string>();
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                string name = Console.ReadLine();
                names.Add(name);

            }
            Console.WriteLine(string.Join("\n", names));
        }
    }
}
