using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BooleanVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            bool boo = Convert.ToBoolean(str);

            if (boo)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                {
                    Console.WriteLine("No");
                }
            }
        }
    }
}
