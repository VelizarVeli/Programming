using System;
using System.Linq;
//решена за 2 часа и 30 минути 100/100
namespace _02._1.Icarus04September0217
{
    class Program
    {
        static void Main()
        {
            int[] plane = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();
            int index = int.Parse(Console.ReadLine());
            string[] commmand = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int damage = 1;
            while (commmand[0] != "Supernova")
            {

                string direction = commmand[0];
                if (direction == "left")
                {
                int step = int.Parse(commmand[1]);
                    for (int i = 0; i < step; i++)
                    {
                        index--;
                        if (index ==-1)
                        {
                            index = plane.Length - 1;
                            damage++;
                        }
                        plane[index] -= damage;
                    }
                }
                else
                {
                    int step = int.Parse(commmand[1]);

                    for (int i = 0; i < step; i++)
                    {
                        index++;
                        if (index > plane.Length - 1)
                        {
                            index = 0;
                            damage++;
                        }
                        plane[index] -= damage;
                    }
                }
                commmand = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }
            Console.WriteLine(string.Join(" ", plane));
        }
    }
}
