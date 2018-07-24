using System;

namespace _01.ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string str = ReverseString(input);
            Console.WriteLine(str);
        }
        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
           return new string(arr);
        }
    }
}
