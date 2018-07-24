using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.ExtractSentencesByKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string searchin = Console.ReadLine();
            var input = Console.ReadLine().Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).Select(a => a.Trim()).ToArray();
            
            var regex = new Regex(@"\b" + searchin + @"\b");

            foreach (var item in input)
            {
                if (regex.IsMatch(item))
                {
                    Console.WriteLine(item);
                }
            }
            
        }
    }
}
