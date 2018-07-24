using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string[] commands = Console.ReadLine().Split(' ').ToArray();
            while (commands[0].ToLower() != "print")
            {
                if (commands[0] == "add")
                {
                    input.Insert(int.Parse(commands[1]), int.Parse(commands[2]));
                }
                else if (commands[0] == "addMany")
                {
                    List<int> addMany = new List<int>();
                    for (int i = 2; i < commands.Length; i++)
                    {
                        addMany.Add(int.Parse(commands[i]));
                    }
                    input.InsertRange(int.Parse(commands[1]), addMany);

                }
                else if (commands[0] == "contains")
                {

                    bool check = false;
                    for (int i = 0; i < input.Count; i++)
                    {
                        if (input[i] == int.Parse(commands[1]))
                        {
                            Console.WriteLine(i);
                            check = false;
                            break;
                        }
                        else
                        {
                            check = true;
                        }
                    }
                    if (check)
                    {
                        Console.WriteLine(-1);
                    }
                }
                else if (commands[0] == "remove")
                {
                    input.RemoveAt(int.Parse(commands[1]));
                }
                else if (commands[0] == "shift")
                {
                    for (int i = 0; i < int.Parse(commands[1]); i++)
                    {
                        input.Add(input[0]);
                        input.RemoveAt(0);
                    }
                }
                else if (commands[0] == "sumPairs")
                {
                    List<int> sum = new List<int>();

                    for (int i = 0; i < input.Count; i += 2)
                    {
                        if (i + 1 >= input.Count)
                        {
                            sum.Add(input[input.Count - 1]);
                            break;
                        }
                        int suma = input[i] + input[i + 1];
                        sum.Add(suma);
                    }
                    input = sum;
                }
                commands = Console.ReadLine().Split(' ').ToArray();
                            }
            Console.WriteLine($"[{string.Join(", ", input)}]");
        }
        public static void ShiftLeft<T>(List<T> lst, int shifts)
        {
            for (int i = shifts; i < lst.Count; i++)
            {
                lst[i - shifts] = lst[i];
            }

            for (int i = lst.Count - shifts; i < lst.Count; i++)
            {
                lst[i] = default(T);
            }
        }
    }
}
