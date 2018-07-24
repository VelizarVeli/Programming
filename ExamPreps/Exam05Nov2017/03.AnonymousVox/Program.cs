using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.AnonymousVox
{
    class Program
    {
        static void Main(string[] args)
        {
            string encodedText = Console.ReadLine();
            List<string> placeholders = Console.ReadLine().Split(new char[] { '{', '}' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            for (int i = 0; i < encodedText.Length; i++)
            {

            string pattern = @"([a-zA-Z]+)(?<name>.*)(\1)";
            var checky = Regex.Match(encodedText, pattern);

            string name = "";
            var result = "";
            Match m = Regex.Match(encodedText, pattern);
            if (m.Success)
            {
                name = m.Groups["name"].Value;
                result = Regex.Replace(encodedText, name, placeholders[0]);
            }


            Console.WriteLine(result);
            string edno = checky.ToString();
            int index = encodedText.IndexOf(edno);

            string cleanPath = (index < 0) ? encodedText : encodedText.Remove(index, edno.Length);
            encodedText = cleanPath;
            }
        }
    }
}
