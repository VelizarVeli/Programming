using System;
// решена за време 1 час и 22 минути 100/100

namespace _02._10.JumpJumpTelerik
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] array = Console.ReadLine().ToCharArray();

            int index = 0;
            int val = (int)Char.GetNumericValue(array[0]);

            while (true)
            {
                if (array[index] == '0')
                {
                    Console.WriteLine("Too drunk to go on after {0}!", index);
                    break;
                }
                if (array[index] == '^')
                {
                    Console.WriteLine("Jump, Jump, DJ Tomekk kommt at {0}!", index);
                    break;
                }
                else if (array[index] % 2 == 0)
                {
                    index += val;
                    if (index < 0 || index >= array.Length)
                    {
                        Console.WriteLine("Fell off the dancefloor at {0}!", index);
                        break;
                    }
                    val = (int)Char.GetNumericValue(array[index]);
                }
                else if (array[index] % 2 == 1)
                {
                    index -= val;
                    if (index < 0 || index >= array.Length)
                    {
                        Console.WriteLine("Fell off the dancefloor at {0}!", index);
                        break;
                    }
                    val = (int)Char.GetNumericValue(array[index]);
                }
            }
        }
    }
}
