using System;
// решена за време 45 минути 100/100

namespace _02._12.GoingToPartyTelerik
{
    class Program
    {
        static void Main()
        {
            char[] input = Console.ReadLine().ToCharArray();
            int index = 0;
            int val = input[index];

            while (true)
            {
                if (val == '^')
                {
                    Console.WriteLine("Djor and Djano are at the party at {0}!", index);
                    break;
                }
                if (index < 0 || index >= input.Length)
                {
                    Console.WriteLine("Djor and Djano are lost at {0}!", index);
                    break;
                }
                val = input[index];
                if (char.IsLower(input[index]))
                {
                    int mover = val - 96;
                    index += mover;
                }
                else if (char.IsUpper(input[index]))
                {
                    int mover = val - 64;
                    index -= mover;
                }
            }
        }
    }
}
