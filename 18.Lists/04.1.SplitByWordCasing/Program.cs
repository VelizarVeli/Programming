using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._1.SplitByWordCasing
{
    class Program
    {
        static void Main(string[] args)
        {
            var separators = new char[] { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' };
            var words = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);
            var lowerCase = new List<string>();
            var upperCase = new List<string>();
            var mixed = new List<string>();

            foreach (var w in words)
            {
                var type = GetWordType(w);
                if (type == WordType.UpperCase)
                {
                    upperCase.Add(w);
                }
                else if(type == WordType.LowerCase)
                {
                    lowerCase.Add(w);
                }
                else
                {
                    mixed.Add(w);
                }
            }
            Console.WriteLine("Lower-case: {0}", string.Join(", ", lowerCase));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixed));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", upperCase));
        }
        enum WordType { UpperCase, MixedCase, LowerCase };

        static WordType GetWordType(string word)
        {
            var lowerLetters = 0;
            var upperLetters = 0;
            foreach (var l in word)
            {
                if (char.IsUpper(l))
                {
                    upperLetters++;
                }
                else if (char.IsLower(l))
                {
                    lowerLetters++;
                }
            }
            if (upperLetters == word.Length)
                return WordType.UpperCase;
            if (lowerLetters == word.Length)
                return WordType.LowerCase;
            return WordType.MixedCase;
        }
    }
}
