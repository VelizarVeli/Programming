using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// решена за време 2 часа и 15 минути 100/100 
namespace _02._4.ExamPreparationIV
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> data = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] commands = input.Split().ToArray();

                if (commands[0] == "exchange")
                {
                    int splitIndex = int.Parse(commands[1]);
                    if (splitIndex >= 0 && splitIndex < data.Count)
                    {
                        Exchange(data, splitIndex);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }

                else if (commands[0] == "max")
                {
                    if (commands[1] == "even")
                    {
                        try
                        {
                            int max = data.Where(x => (x % 2) == 0).Max();
                            int maxIndex = data.LastIndexOf(max);
                            Console.WriteLine(maxIndex);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("No matches");
                        }
                    }
                    else
                    {
                        int max;
                        try
                        {
                            max = data.Where(x => (x % 2) == 1).Max();
                            int maxIndex = data.LastIndexOf(max);
                            Console.WriteLine(maxIndex);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("No matches");
                        }
                    }
                }
                else if (commands[0] == "min")
                {
                    if (commands[1] == "even")
                    {
                        try
                        {
                            int min = data.Where(x => (x % 2) == 0).Min();
                            int minIndex = data.LastIndexOf(min);
                            Console.WriteLine(minIndex);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("No matches");
                        }
                    }
                    else
                    {
                        try
                        {
                            int min = data.Where(x => (x % 2) == 1).Min();
                            int minIndex = data.LastIndexOf(min);
                            Console.WriteLine(minIndex);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("No matches");
                        }
                    }
                }
                else if (commands[0] == "first")
                {
                    int count = int.Parse(commands[1]);
                    if (count <= data.Count)
                    {
                        if (commands[2] == "even")
                        {

                            int[] numbers = data.Where(x => (x % 2) == 0).Take(count).Select(i => i).ToArray();

                            Console.WriteLine($"[{string.Join(", ", numbers)}]");
                        }
                        else
                        {
                            int[] numbers = data.Where(x => (x % 2) == 1).Take(count).Select(i => i).ToArray();

                            Console.WriteLine($"[{string.Join(", ", numbers)}]");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid count");
                    }
                }

                else if (commands[0] == "last")
                {
                    int count = int.Parse(commands[1]);
                    if (count <= data.Count)
                    {
                        if (commands[2] == "even")
                        {

                            int[] numbers = data.Where(x => (x % 2) == 0).Reverse().Take(count).Reverse().Select(i => i).ToArray();

                            Console.WriteLine($"[{string.Join(", ", numbers)}]");
                        }
                        else
                        {
                            int[] numbers = data.Where(x => (x % 2) == 1).Reverse().Take(count).Reverse().Select(i => i).ToArray();

                            Console.WriteLine($"[{string.Join(", ", numbers)}]");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid count");
                    }
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"[{string.Join(", ", data)}]");
        }

        public static List<int> Exchange(List<int> data, int splitIndex)
        {
            List<int> cut = new List<int>();
            cut = data.GetRange(0, splitIndex + 1);
            data.RemoveRange(0, splitIndex + 1);
            data.AddRange(cut);

            return data;
        }

    }
}
