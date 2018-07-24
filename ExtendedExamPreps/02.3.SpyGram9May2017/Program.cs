using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
//решена за 2 часа и 5 минути 100/100
namespace _02._3.SpyGram9May2017
{
    class Program
    {
        static void Main()
        {
            string code = Console.ReadLine();
            string pattern = @"^(TO: ){1}([A-Z]+); MESSAGE: (.+);";
            string input = Console.ReadLine();
            SortedDictionary<string,List<string>> pendingMessages = new SortedDictionary<string, List<string>>();
            while (input != "END")
            {
                Regex regex = new Regex(pattern);
                Match match = regex.Match(input);
                char[] input1 = input.ToCharArray();

                if (match.Success)
                {
                    int index = 0;
                    for (int i = 0; i < input1.Length; i++)
                    {
                        if (index > code.Length - 1)
                        {
                            index = 0;
                        }
                        char codeNum = code[index];
                        int num = codeNum - 48;
                        input1[i] = (char)(input1[i] + num);
                        index++;
                    }
                    string input2 = new string(input1);
                    if (!pendingMessages.ContainsKey(match.Groups[2].Value))
                    {
                        pendingMessages.Add(match.Groups[2].Value, new List<string>());
                    }
                    pendingMessages[match.Groups[2].Value].Add(input2);
                }
                input = Console.ReadLine();

            }
            foreach (var message in pendingMessages)
            {
                foreach (var mess in message.Value)
                {

                    Console.WriteLine(mess);
                }
            }
        }
    }
}
