using System;

namespace _11.DifferentNumbers
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int i = 0;
            int j = 0;
            int k = 0;
            int l = 0;
            int m = 0;
            bool check = true;

            for (i = a; i <= b; i++)
            {
                for (j = a; j <= b; j++)
                {
                    for (k = a; k <= b; k++)
                    {
                        for (l = a; l <= b; l++)
                        {
                            for (m = a; m <= b; m++)
                            {
                                if (i < j && j < k && k < l && l < m)
                                {
                                    Console.WriteLine($"{i} {j} {k} {l} {m}");
                                    check = false;
                                }
                            }
                        }
                    }
                }
            }
            if  (check) 
            {
                Console.WriteLine("No");
            }
        }
    }
}
