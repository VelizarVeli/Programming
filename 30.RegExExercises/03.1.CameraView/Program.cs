using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03CameraView
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int skip = nums[0];
            int take = nums[1];

            string pattern = "\\|<(\\w{" + skip + "})(\\w{0," + take + "})";
            string input = Console.ReadLine();
            MatchCollection matchedResult = Regex.Matches(input, pattern);
            List<string> res = new List<string>();
            foreach (Match m in matchedResult)
            {
                res.Add(m.Groups[2].Value);
            }
            Console.WriteLine(string.Join(", ", res));
        }
    }
}