using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.AppendLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> first = Console.ReadLine().Split('|').ToList();
            first.Reverse();
            var result = new List<string>();

            foreach (var item in first)
            {
                List<string> babys = item.Split(' ').ToList();
                foreach (var baby in babys)
                {
                    if(baby != "")
                    {
                        result.Add(baby);
                    }
                }
            }
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
