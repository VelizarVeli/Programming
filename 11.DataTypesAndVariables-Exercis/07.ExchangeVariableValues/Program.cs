using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.ExchangeVariableValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            int temp = 0;
            Console.WriteLine($"Before:\na = {a}\nb = {b}");
            temp = a;
            a = b;
            b = temp;

            Console.WriteLine($"After:\na = {a}\nb = {b}");
        }
    }
}
