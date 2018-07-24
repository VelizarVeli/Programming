using System;

namespace _14.BoatSimulator
{
    class Program
    {
        static void Main()
        {
            char firstBoat = char.Parse(Console.ReadLine());
            char secondBoat = char.Parse(Console.ReadLine());
            byte n = byte.Parse(Console.ReadLine());

            int movesFirstBoat = 0;
            int movesSecondBoat = 0;

            for (int i = 1; i <= n; i++)
            {
                string moves = Console.ReadLine();
                if (moves == "UPGRADE")
                {
                    firstBoat += (char)3;
                    secondBoat += (char)3;
                }
                else if (i % 2 == 1)
                {
                    movesFirstBoat += moves.Length;
                }
                else if (i % 2 == 0)
                {
                    movesSecondBoat += moves.Length;
                }
                if (movesFirstBoat >= 50 || movesSecondBoat >= 50)
                {
                    break;
                }
            }

            if(movesFirstBoat > movesSecondBoat)
            {
                Console.WriteLine(firstBoat);
            }
            else
            {
                Console.WriteLine(secondBoat);

            }
        }
    }
}
