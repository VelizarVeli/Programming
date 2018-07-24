using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
// решена за време 2 часа и 25 минути 45/100 
// решена 100/100 с подсказки за % деление за оптимизация на повторенията, дефиниране на крайните стойности
namespace _02._3.ExamPreparationIII
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> data = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            string inputCommands = Console.ReadLine();
            while (inputCommands != "end")
            {
                string[] commands = inputCommands.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (commands[0] == "reverse")
                {
                    int start = int.Parse(commands[2]);
                    int count = int.Parse(commands[4]);
                    if (start >= 0 && start < data.Count && (start + count) <= data.Count && count >= 0)
                    {
                        Reverse(data, start, count);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                }
                else if (commands[0] == "sort")
                {
                    int start = int.Parse(commands[2]);
                    int count = int.Parse(commands[4]);
                    if (start >= 0 && start < data.Count && (start + count) <= data.Count && count >= 0)
                    {
                        Sort(data, start, count);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }

                }
                else if (commands[0] == "rollLeft")
                {
                    int count = int.Parse(commands[1]);
                    if (count >= 0)
                    {
                        RollLeft(data, count);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                }
                else if (commands[0] == "rollRight")
                {
                    int count = int.Parse(commands[1]);
                    if (count >= 0)
                    {
                        RollRight(data, count);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                }
                inputCommands = Console.ReadLine();
            }
            Console.WriteLine($"[{string.Join(", ", data)}]");
        }

        public static void Reverse(List<string> data, int start, int count)
        {
            data.Reverse(start, count);
        }

        public static void Sort(List<string> data, int start, int count)
        {

            List<string> ForSort = new List<string>();
            ForSort = data.GetRange(start, count);
            ForSort.Sort();
            List<string> end = new List<string>();
            end = data.GetRange((start + count), (data.Count - count - start));
            data.RemoveRange(start, data.Count - start);
            data.AddRange(ForSort);
            data.AddRange(end);
        }

        public static void RollLeft(List<string> data, int count)
        {
            //процентно деление за оптимизация на деленията
            count = count % data.Count;
            List<string> cut = new List<string>();
            cut = data.GetRange(0, count);
            data.RemoveRange(0, count);
            data.AddRange(cut);
        }

        public static void RollRight(List<string> data, int count)
        {
            //процентно деление за оптимизация на деленията
            count = count % data.Count;
            for (int i = 0; i < count; i++)
            {
                List<string> cut = new List<string>();
                cut = data.GetRange(data.Count - 1, 1);
                data.InsertRange(0,cut);
                data.RemoveRange(data.Count - 1, 1);
            }

            //List<string> cut = new List<string>();
            //cut = data.GetRange(data.Count - count, count);
            //data.RemoveRange(data.Count - count, count);
            //data.InsertRange(0, cut);
        }
    }
}
