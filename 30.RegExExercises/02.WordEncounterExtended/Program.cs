using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WordEncounter
{
    class WordEncounter
    {
        static void Main(string[] args)
        {
            var filter = Console.ReadLine();
            var line = Console.ReadLine();
            var result = new List<string>();

            while (line != "end")
            {
                //Check's for sentance match.
                var isMatch = Regex.IsMatch(line, @"(?<!.)[A-Z](.*)[.!?](?!.)"); //negative lookbehind and negative lookahead.

                if (isMatch)
                {
                    //Take's each word from sentance.
                    var words = Regex.Matches(line, @"(\w+)");

                    foreach (Match word in words)
                    {
                        var letter = filter[0];
                        var minLenght = int.Parse(filter[1].ToString());
                        var currentWord = word.Groups[0].Value;
                        var counter = 0;
                        for (int i = 0; i < currentWord.Length; i++)
                        {
                            if (currentWord[i] == letter)
                            {
                                counter++;
                            }
                        }

                        if (counter >= minLenght)
                        {
                            result.Add(currentWord);
                        }

                        counter = 0;
                    }
                }

                line = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}