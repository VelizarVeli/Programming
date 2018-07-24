using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace broiach
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100000000; i++)
            {
                Console.Write(i);
                Console.Write('\r');
            }
        }
    }
}
