using System;
using System.Linq;
// решена за време час и 34 минути 100/100 

namespace _02._7.Again11September2016
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] priceRange = Console.ReadLine().Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries).Select(decimal.Parse).ToArray();
            int entryPoint = int.Parse(Console.ReadLine());
            string items = Console.ReadLine();
            string priceRatings = Console.ReadLine();

            decimal leftSum = 0;
            decimal rightSum = 0;

            if (items == "cheap")
            {
                if (priceRatings == "positive")
                {
                    for (int i = 0; i < entryPoint; i++)
                    {
                        if (priceRange[i] < priceRange[entryPoint] && priceRange[i] > 0)
                        {
                            leftSum += priceRange[i];
                        }
                    }
                    for (int i = entryPoint + 1; i < priceRange.Length; i++)
                    {
                        if (priceRange[i] < priceRange[entryPoint] && priceRange[i] > 0)
                        {
                            rightSum += priceRange[i];
                        }
                    }
                }
                else if (priceRatings == "negative")
                {
                    for (int i = 0; i < entryPoint; i++)
                    {
                        if (priceRange[i] < priceRange[entryPoint] && priceRange[i] < 0)
                        {
                            leftSum += priceRange[i];
                        }
                    }
                    for (int i = entryPoint + 1; i < priceRange.Length; i++)
                    {
                        if (priceRange[i] < priceRange[entryPoint] && priceRange[i] < 0)
                        {
                            rightSum += priceRange[i];
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < entryPoint; i++)
                    {
                        if (priceRange[i] < priceRange[entryPoint])
                        {
                            leftSum += priceRange[i];
                        }
                    }
                    for (int i = entryPoint + 1; i < priceRange.Length; i++)
                    {
                        if (priceRange[i] < priceRange[entryPoint])
                        {
                            rightSum += priceRange[i];
                        }
                    }
                }
            }
            else
            {
                if (priceRatings == "positive")
                {
                    for (int i = 0; i < entryPoint; i++)
                    {
                        if (priceRange[i] >= priceRange[entryPoint] && priceRange[i] > 0)
                        {
                            leftSum += priceRange[i];
                        }
                    }
                    for (int i = entryPoint + 1; i < priceRange.Length; i++)
                    {
                        if (priceRange[i] >= priceRange[entryPoint] && priceRange[i] > 0)
                        {
                            rightSum += priceRange[i];
                        }
                    }
                }
                else if (priceRatings == "negative")
                {
                    for (int i = 0; i < entryPoint; i++)
                    {
                        if (priceRange[i] >= priceRange[entryPoint] && priceRange[i] < 0)
                        {
                            leftSum += priceRange[i];
                        }
                    }
                    for (int i = entryPoint + 1; i < priceRange.Length; i++)
                    {
                        if (priceRange[i] >= priceRange[entryPoint] && priceRange[i] < 0)
                        {
                            rightSum += priceRange[i];
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < entryPoint; i++)
                    {
                        if (priceRange[i] >= priceRange[entryPoint])
                        {
                            leftSum += priceRange[i];
                        }
                    }
                    for (int i = entryPoint + 1; i < priceRange.Length; i++)
                    {
                        if (priceRange[i] >= priceRange[entryPoint])
                        {
                            rightSum += priceRange[i];
                        }
                    }
                }
            }
            if (rightSum > leftSum)
            {
                Console.WriteLine($"Right - {rightSum}");
            }
            else
            {
                Console.WriteLine($"Left - {leftSum}");
            }
        }
    }
}
