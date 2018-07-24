using System;

namespace _06.CatchTheThief
{
    class Program
    {
        static void Main()
        {
            string numeralType = Console.ReadLine();
            int lines = int.Parse(Console.ReadLine());
            long idCounter = -9223372036854775808;
            for (int i = 0; i < lines; i++)
            {
                long ids = long.Parse(Console.ReadLine());

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
            Console.WriteLine(idCounter);
        }
    }
}
