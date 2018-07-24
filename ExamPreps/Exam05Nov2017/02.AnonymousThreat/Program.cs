using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            string[] commands = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            while (commands[0] != "3:1")
            {
                string command = commands[0];
                int startIndex = int.Parse(commands[1]);
                int endIndex = int.Parse(commands[2]);
                string merged = "";
                if (command == "merge")
                {
                    if (startIndex > input.Count)
                    {
                        goto end;
                    }
                    if (endIndex > input.Count)
                    {
                        endIndex = input.Count - 1;
                        if (startIndex == endIndex)
                        {
                            goto end;
                        }
                    }
                    for (int i = 0; i < input.Count; i++)
                    {
                        if (startIndex <= i && endIndex >= i)
                        {
                            merged += input[i];
                        }
                    }
                    input.RemoveRange(startIndex, endIndex - startIndex + 1);
                    input.Insert(startIndex, merged);
                }
                else
                {
                    string devided = input[startIndex];
                    input.RemoveAt(startIndex);
                    if (devided.Length % endIndex == 0)
                    {
                        for (int i = devided.Length; i >= 0; i += endIndex)
                        {
                            string checking = devided.Substring(0, endIndex);
                            checking += checking + " ";
                        }
                        input.Add(checking);
                    }
                }
                end:
                commands = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
