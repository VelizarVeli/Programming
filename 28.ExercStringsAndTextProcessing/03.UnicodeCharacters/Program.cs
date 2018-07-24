using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.UnicodeCharacters
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            var chars = input.Select(c => (int)c).Select(c => $@"\u{c:x4}");

            var result = string.Concat(chars);

            Console.WriteLine(result);

            //StringBuilder sb = new StringBuilder();
            //foreach (char c in sb)
            //{
            //    sb.AppendFormat("\\u{0:X4}", (uint)c);
            //    string str= sb.ToString();
            //}
        }
    }
}
