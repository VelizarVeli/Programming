using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02._4.WormIpsum30April2017
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            while (input != "Worm Ipsum")
            {
                Match validateSentence = Regex.Match(input, @"^[A-Z]{1}[\w]+([\w ]*)*\.$");
                string[] input1 = input.Split(new[] { ' ', '.' }, StringSplitOptions.RemoveEmptyEntries);
                if (validateSentence.Success)
                {
                    for (int i = 0; i < input1.Length; i++)
                    {
                        int count = 0;
                        char[] currentWord = input1[i].Trim('.').ToCharArray();
                        char letter = '1';
                        for (int j = 0; j < currentWord.Length; j++)
                        {
                            int currentCount = 0;
                            for (int k = j + 1; k < currentWord.Length; k++)
                            {
                                if (currentWord[j] == currentWord[k])
                                {
                                    currentCount++;
                                    if (count < currentCount)
                                    {
                                        count = currentCount;
                                        letter = currentWord[j];
                                    }
                                }
                            }
                        }
                        if (count != 0)
                        {
                            string replaced = new string(letter, currentWord.Length);
                            input1[i] = replaced;
                        }
                    }
                    Console.WriteLine($"{string.Join(" ", input1)}.");
                }
                input = Console.ReadLine();
            }
        }

    }
}
