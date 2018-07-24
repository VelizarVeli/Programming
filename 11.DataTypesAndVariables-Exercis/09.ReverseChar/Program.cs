using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.ReverseChar
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            char c = char.Parse(Console.ReadLine());
            char temp = ' ';

            temp = a;
            a = c;
            c = temp;

            Console.WriteLine($"{a}{b}{c}");
        }
    }
}
