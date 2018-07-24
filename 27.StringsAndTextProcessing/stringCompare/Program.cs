using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {

            //CASE SENSITIVE
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();

            int result = string.Compare(str1, str2, true);
            if (result == 1)
            {
                Console.WriteLine(str2);
            }
            else
            {
                Console.WriteLine(str1);
            }

            //CASE INSENSITIVE
            string str3 = Console.ReadLine();
            string str4 = Console.ReadLine();

            int result1 = string.Compare(str1, str2, false);
            if (result1 == 1)
            {
                Console.WriteLine(str2);
            }
            else
            {
                Console.WriteLine(str1);
            }
        }
    }
}
