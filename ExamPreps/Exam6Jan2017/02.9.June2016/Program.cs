using System;
using System.Linq;
// решена за време 50 минути 100/100 

namespace _02._9.June2016
{
    class Program
    {
        static void Main()
        {
            long[] data = Console.ReadLine().Split().Select(long.Parse).ToArray();
            string[] commands = Console.ReadLine().Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries).ToArray();

            while (commands[0] != "end")
            {
                string command = commands[0];
                if (command == "decrease")
                {
                    data = Array.ConvertAll(data, x => x - 1);
                }
                else if (command == "swap")
                {
                    int com1 = int.Parse(commands[1]);
                    int com2 = int.Parse(commands[2]);
                    long num1 = data[com1];
                    long num2 = data[com2];
                    data[com1] = num2;
                    data[com2] = num1;
                }
                else
                {
                    int com1 = int.Parse(commands[1]);
                    int com2 = int.Parse(commands[2]);

                    data[com1] = data[com1] * data[com2];
                }
                commands = Console.ReadLine().Split().ToArray();
            }
            Console.WriteLine(string.Join(", ",data));
        }
    }
}
