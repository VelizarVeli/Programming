using System;
using System.Collections.Generic;
using System.Linq;

//решена за 1 час и 31 минути 100/100
namespace _02.Rainer
{
    class Program
    {
        static void Main()
        {
            List<int> input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int step = input[input.Count - 1];
            input.RemoveAt(input.Count - 1);
            int[] gameField = input.ToArray();
            int counter = -1;
            while (true)
            {
                counter++;
                for (int i = 0; i < gameField.Length; i++)
                {
                    gameField[i] -= 1;
                }

                if (gameField[step] == 0)
                {
                    break;
                }
                for (int j = 0; j < gameField.Length; j++)
                {
                    if (gameField[j] == 0)
                    {
                        gameField[j] = input[j];
                    }
                }
                step = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"{string.Join(" ", gameField)}");
            Console.WriteLine(counter);
        }
    }
}
