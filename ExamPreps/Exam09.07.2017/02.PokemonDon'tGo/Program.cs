using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.PokemonDon_tGo
{
    class Program
    {
        static void Main()
        {
            List<long> input = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            long sumValueRemovedElements = 0;

            while (true)
            {
                int index = int.Parse(Console.ReadLine());
               
                if (index < 0)
                {
                    long indexValue = input[0];
                    sumValueRemovedElements += indexValue;
                    input.RemoveAt(0);
                    input.Insert(0, input.Count - 1);
                    for (int i = 0; i < input.Count; i++)
                    {
                        if (input[i] <= indexValue)
                        {
                            input[i] += indexValue;
                        }
                        else
                        {
                            input[i] -= indexValue;
                        }
                    }
                }

                else if(index >= input.Count)
                {
                    long indexValue = input[input.Count - 1];
                    sumValueRemovedElements += indexValue;
                    input.RemoveAt(input.Count - 1);
                    input.Add(input[0]);
                    for (int i = 0; i < input.Count; i++)
                    {
                        if (input[i] <= indexValue)
                        {
                            input[i] += indexValue;
                        }
                        else
                        {
                            input[i] -= indexValue;
                        }
                    }
                }

                else
                {
                    long indexValue = input[index];
                    sumValueRemovedElements += indexValue;
                    input.RemoveAt(index);
                    for (int i = 0; i < input.Count; i++)
                    {

                        if (input[i] <= indexValue)
                        {
                            input[i] += indexValue;
                        }
                        else
                        {
                            input[i] -= indexValue;
                        }
                    }
                }


                if (input.Count == 0)
                {
                    break;
                }
            }
            Console.WriteLine(sumValueRemovedElements);
        }
    }
}
