using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.StringsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello";
            string world = "World";
            char space = ' ';
            object helloWorld = hello + space + world;
            string all = (string)helloWorld;
            
            Console.WriteLine(all);
        }
    }
}
