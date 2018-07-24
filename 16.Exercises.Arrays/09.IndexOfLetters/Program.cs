using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var charArray = input.ToCharArray();

            char[] alphabet = new char[26];
            char alph = 'a';
            for (int i = 0; i < alphabet.Length; i++)
            {
                alphabet[i] = alph;
                alph++;
            }

            for (int i = 0; i < charArray.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (charArray[i] == alphabet[j])
                    {
                        Console.WriteLine($"{charArray[i]} -> {j}");
                    }
                }
            }
        }
    }
}
