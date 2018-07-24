using System;

namespace _08.GreaterOfTwoValues
{
    class Program
    {
        static int GetMax(int first, int second)
        {
            if (first < second)
            {
                return second;
            }
            else
                return first;
        }
        static char GetMax(char first, char second)
        {
            if (first < second)
            {
                return second;
            }
            else
                return first;
        }
        static string GetMax(string first, string second)
        {
            if (first.CompareTo(second) < 0)
            {
                return second;
            }
            else 
                return first;
        }
        static void Main()
        {
            string type = Console.ReadLine();
            if (type == "int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                int max = GetMax(first, second);
                Console.WriteLine(max);
            }
            if (type == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                char max = GetMax(first, second);
                Console.WriteLine(max);
            }
            if (type == "string")
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                string max = GetMax(first, second);
                Console.WriteLine(max);
            }
        }
    }
}
