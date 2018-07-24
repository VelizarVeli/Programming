using System;

namespace _07.Greeting
{
    class Program
    {
        static void Main()
        {
            string first = Console.ReadLine();
            string last = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine($"Hello, {first} {last}.\r\nYou are {age} years old.");
        }
    }
}
