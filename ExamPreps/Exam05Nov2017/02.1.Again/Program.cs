using System;
using System.Collections.Generic;
using System.Linq;
//Решена за втори път 50/100 за 2 часа, 100/100 с малка подсказка

namespace _02._1.Again
{
    class Program
    {
        static void Main()
        {
            List<string> input = Console.ReadLine().Split().ToList();
            string[] commands = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            while (commands[0] != "3:1")
            {
                string command = commands[0];
                int firstInd = int.Parse(commands[1]);
                int secondInd = int.Parse(commands[2]);

                string merged = "";
                if (command == "merge")
                {
                    if (firstInd < 0)
                    {
                        firstInd = 0;
                    }
                    if (secondInd < 0)
                    {
                        secondInd = 0;
                    }
                    if (secondInd >= input.Count)
                    {
                        secondInd = input.Count - 1;
                    }
                    if (secondInd <= firstInd)
                    {
                        goto End;
                    }
                    int range = secondInd - firstInd + 1;
                    for (int i = firstInd; i <= secondInd; i++)
                    {

                        merged += input[i];
                    }
                    input.RemoveRange(firstInd, range);
                    input.Insert(firstInd, merged);

                }
                else
                {
                    if (firstInd >= 0 && secondInd > 0)
                    {

                        string forDivision = input[firstInd];
                        int chungSize = forDivision.Length / secondInd;
                        List<string> devised = new List<string>();
                        for (int i = 0; i < secondInd; i++)
                        {
                            if (i == secondInd - 1)
                            {
                                devised.Add((forDivision));
                                break;
                            }
                            string part = forDivision.Substring(0, chungSize);
                            forDivision = forDivision.Substring(chungSize);
                            devised.Add(part);
                        }
                        input.RemoveAt(firstInd);
                        input.InsertRange(firstInd, devised);
                    }
                }
                End:
                commands = Console.ReadLine().Split();
            }
            Console.WriteLine(String.Join(" ", input));
        }
    }
}
