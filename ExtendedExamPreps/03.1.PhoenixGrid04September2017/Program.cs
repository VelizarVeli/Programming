using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._1.PhoenixGrid04September2017
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            while (input != "ReadMe")
            {
                bool trfalse = true;
                string[] check1 = input.Split(new[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < check1.Length; i++)
                {
                    if (check1[i].Length != 3 || check1[i].Contains('_') || check1[i].Contains(" "))
                    {
                        trfalse = false;
                        Console.WriteLine("NO");
                        break;
                    }
                }
                if (trfalse)
                {
                    int rtb = input.Length / 2 + 1;
                    string left = input.Substring(input.Length / 2 + 1);
                    string right = input.Substring(0, input.Length / 2);
                    right = ReverseStringDirect(right);
                    bool areEqual = String.Equals(left, right, StringComparison.CurrentCulture);
                    if (areEqual)
                    {
                        Console.WriteLine("YES");
                    }
                    else
                    {
                        Console.WriteLine("NO");
                    }
                }

                input = Console.ReadLine();
            }
        }
        public static string ReverseStringDirect(string s)
        {
            char[] array = new char[s.Length];
            int forward = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                array[forward++] = s[i];
            }
            return new string(array);
        }
    }
}
