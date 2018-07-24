using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//решена за 57 минути 90/100
namespace _03._3.Spyfer9May2017
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            while (true)
            {
                bool checky = true;
                if (input.Count < 2)
                {
                    break;
                }
                for (int i = 0; i < input.Count; i++)
                {
                    if (i == 0)
                    {
                        if (input[i] == input[i + 1])
                        {
                            input.RemoveAt(i + 1);

                            i = 0;
                        }
                    }
                    else if (i == input.Count - 1)
                    {
                        if (input[i] == input[i - 1])
                        {
                            input.RemoveAt(i - 1);

                            i = 0;
                        }
                    }
                    else if (input[i - 1] + input[i + 1] == input[i])
                    {
                        input.RemoveAt(i + 1);
                        input.RemoveAt(i - 1);
                        checky = false;
                        i = 0;
                    }
                }
                if (checky)
                {
                    break;
                }
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
