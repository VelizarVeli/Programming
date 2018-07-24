using System;

namespace _07.SentenceTheThief
{
    class Program
    {
        static void Main()
        {
            string numeralType = Console.ReadLine();
            int lines = int.Parse(Console.ReadLine());
            long idCounter = -9223372036854775808;
            long ids = 0;

            for (int i = 0; i < lines; i++)
            {
                ids = long.Parse(Console.ReadLine());

                if (numeralType == "sbyte")
                {
                    if (ids <= sbyte.MaxValue && ids >= sbyte.MinValue)
                    {
                        if (ids > idCounter)
                            idCounter = ids;
                    }
                }
                else if (numeralType == "int")
                {
                    if (ids <= int.MaxValue && ids >= int.MinValue)
                    {
                        if (ids > idCounter)
                            idCounter = ids;
                    }
                }
                else if (numeralType == "long")
                {
                    if (ids <= long.MaxValue && ids >= long.MinValue)
                    {
                        if (ids > idCounter)
                            idCounter = ids;
                    }
                }
            }
            if (idCounter <= sbyte.MaxValue && idCounter >= sbyte.MinValue)
            {
                Console.WriteLine($"Prisoner with id {idCounter} is sentenced to 1 year");
            }
            else
            {
                if (idCounter < -126)
                {
                    long negative = (long)Math.Ceiling(idCounter / -128m);
                    Console.WriteLine($"Prisoner with id {idCounter} is sentenced to {negative} years");
                }
                else
                {
                    long negative = (long)Math.Ceiling(idCounter / 127m);
                    Console.WriteLine($"Prisoner with id {idCounter} is sentenced to {negative} years");
                }
            }
        }
    }
}