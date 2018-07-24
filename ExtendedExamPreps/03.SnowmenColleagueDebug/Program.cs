using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Snowballs
{
    class Program
    {
        static void Main()
        {
            var sequence = Console.ReadLine().Split().Select(int.Parse).ToList();

            int sequenceLenght = sequence.Count;

            int difference = 0;

            List<int> removeList = new List<int>();

            while (sequence.Count > 1)
            {


                for (int i = 0; i < sequence.Count; i++)
                {

                    var attacker = i;
                    var target = sequence[i];

                    if (removeList.Contains(target))
                    {
                        continue;
                    }

                    if (target > sequenceLenght)
                    {
                        target = target - (target / sequenceLenght) * sequenceLenght;
                    }


                    if (target == attacker)
                    {
                        Console.WriteLine($"{attacker} performed harakiri");
                        removeList.Add(sequence[i]);

                    }
                    else
                    {
                        difference = Math.Abs(target - attacker);

                        if (difference % 2 == 0)
                        {
                            Console.WriteLine($"{attacker} x {target} -> {attacker} wins.");
                            removeList.Add(sequence.ElementAt(target));

                        }
                        else
                        {
                            Console.WriteLine($"{attacker} x {target} -> {target} wins.");
                            removeList.Add(sequence.ElementAt(target));

                        }
                    }



                }



                //PROBLEM COLLECTION WAS MODIFIED...

                for (int i = 0; i < removeList.Count; i++)
                {
                    
                }
                foreach (var item in removeList)
                {
                    if (sequence.Contains(item))
                    {
                        sequence.Remove(item);
                    }
                }




                removeList.Clear();
                sequenceLenght = sequence.Count;
            }
        }
    }
}