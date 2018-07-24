using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Snowmen
{
    class Program
    {
        static void Main()
        {
            List<int> input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            while (input.Count != 1)
            {
                for (int i = 0; i < input.Count; i++)
                {
                    int attacker = i;
                    int target = input[i];
                    if (target > input.Count)
                    {
                        target %= input.Count;
                    }
                    if (input[i] == -1)
                    {
                        continue;
                    }
                    int value = Math.Abs(attacker - target);
                    if (attacker == target)
                    {
                        Console.WriteLine($"{attacker} performed harakiri");
                        input[target] = -1;
                        input[attacker] = -1;
                    }
                    else if (value % 2 == 0)
                    {
                        Console.WriteLine($"{attacker} x {target} -> {attacker} wins");
                        input[target] = -1;
                    }
                    else if (value % 2 == 1)
                    {
                        Console.WriteLine($"{attacker} x {target} -> {target} wins");
                        input[attacker] = -1;
                    }


                }
                for (int i = 0; i < input.Count; i++)
                {
                    if (input.Count == 1)
                    {
                        break;
                    }
                    if (input[i] == -1)
                    {
                        input.Remove(input[i]);
                        i--;
                    }
                }
            }
        }
    }
}