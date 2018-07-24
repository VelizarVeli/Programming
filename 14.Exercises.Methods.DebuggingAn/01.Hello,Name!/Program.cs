using System;

namespace _01.Hello_Name_
{
    class Program
    {
        static string Print(string name)
        {
            Console.WriteLine($"Hello, {name}!");
            return name;
        }
        static void Main()
        {
            string stringa = Console.ReadLine();
            Print(stringa);
        }
    }
}
