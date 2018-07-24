using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ',', '?',' ','.', '!'},StringSplitOptions.RemoveEmptyEntries).ToArray();
            List<string> palindromes = new List<string>();
            for (int i = 0; i < input.Length; i++)
            {
                string word = input[i];
                string firstSub = word.Substring(0, word.Length / 2);
                string wordReversed = WordReverse(word);
                string secondSub = wordReversed.Substring(0, word.Length / 2);
                if (firstSub == secondSub)
                {
                    if (!palindromes.Contains(word))
                    {
                        palindromes.Add(word);
                    }
                }
            }
            string[] ordered = palindromes.OrderBy(x => x).ToArray();
            
                Console.WriteLine(string.Join(", ",ordered));
            

        }
        public static string WordReverse(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
