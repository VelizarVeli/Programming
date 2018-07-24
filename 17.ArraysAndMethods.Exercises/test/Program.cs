using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[4];
            array[0] = 3;
            array[1] = 33;
            array[2] = 4390542;
            array[3] = 540;

            int check = Array.IndexOf(array, 4390542);
            Console.WriteLine(check);
        }
    }
}
