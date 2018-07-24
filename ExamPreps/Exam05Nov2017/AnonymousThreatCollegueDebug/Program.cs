using System;
using System.Collections.Generic;
using System.Linq;

namespace anonymousthreat
{
    class Program
    {
        static void Main()
        {
            string words = Console.ReadLine();
            string input = Console.ReadLine();
            while (input != @"3:1")
            {
                string[] commands = input.Split(' ').ToArray();
                string command = commands[0];
                int param1 = int.Parse(commands[1]);
                int param2 = int.Parse(commands[2]);
                if (command == "merge")
                {
                    if (param1 <= words.Trim().Split(' ').Length - 1 && param1 >= 0)
                    {
                        if (param2 > words.Trim().Split(' ').Length - 1)
                        {
                            param2 = words.Trim().Split(' ').Length - 1;
                        }
                        if (param2 < 0)
                        {
                            param2 = 0;
                        }
                        words = Merge(param1, param2, words.Trim());
                    }
                }
                if (command == "divide")
                {
                    if (param1 <= words.Trim().Split(' ').ToArray().Length - 1 && param2 > 0 && param1 >= 0)
                    {
                        words = Divide(param1, param2, words.Trim());
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(words.Trim());
        }

        private static string Divide(int index, int parts, string array)
        {
            string result = "";
            string start = "";
            string end = "";
            string[] words = array.Split(' ').ToArray();
            for (int i = 0; i < index; i++)
            {
                start = start + " " + words[i];
            }
            for (int i = index + 1; i <= words.Length - 1; i++)
            {
                end = end + " " + words[i];
            }
            string word2 = words[index];
            List<char> word = new List<char>();
            for (int i = 0; i < word2.Length; i++)
            {
                word.Add(word2[i]);
            }
            int part = word2.Length / parts;
            int lastPart = part + word2.Length % parts;
            string pieces = "";
            for (int i = 0; i < parts - 1; i++)
            {
                for (int j = 0; j < part; j++)
                {
                    pieces = pieces + word[0];
                    word.Remove(word[0]);
                }
                pieces = pieces + " ";
            }
            for (int i = 0; i < lastPart; i++)
            {
                pieces = pieces + word[i];
            }
            result = start.Trim() + " " + pieces.Trim() + " " + end.Trim();
            return result;
        }

        private static string Merge(int indexStart, int indexEnd, string array)
        {
            string[] words = array.Split(' ').ToArray();
            string joined = "";
            string start = "", end = "";
            for (int i = 0; i < indexStart; i++)
            {
                start = start + " " + words[i];
            }
            for (int i = indexStart; i <= indexEnd; i++)
            {
                joined = joined + words[i];
            }
            for (int i = indexEnd + 1; i <= words.Length - 1; i++)
            {
                end = end + " " + words[i];
            }
            string[] final = { start.Trim(), joined, end.Trim() };
            string result = string.Join(" ", final);
            return result;
        }
    }
}