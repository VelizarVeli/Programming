using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testy
{
    class Program
    {
        static void Main(string[] args)
        {
            string deset = "1234567890";
            int index = deset.Length;
            int indexi = deset.IndexOf('5');
            Console.WriteLine(index);
            Console.WriteLine(indexi);
        }
    }
}
