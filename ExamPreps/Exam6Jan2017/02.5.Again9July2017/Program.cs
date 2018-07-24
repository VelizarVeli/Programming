using System;
using System.Collections.Generic;
using System.Linq;

// решена за време 1 час и 5 минути 100/100 
namespace _02._5.Again9July2017
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> data = Console.ReadLine().Split().Select(int.Parse).ToList();
            int index = int.Parse(Console.ReadLine());
            long counter = 0;
            while (true)
            {
                if (index < 0)
                {
                    int number = data[0];
                    data[0] = data[data.Count - 1];
                    counter += number;
                    IncreaseDecreaseValueOfElements(data, number);
                }
                else if(index >= data.Count)
                {

                    int number = data[data.Count - 1];
                    data[data.Count - 1] = data[0];
                    counter += number;
                    IncreaseDecreaseValueOfElements(data, number);
                }
                else
                {
                    int number = data[index];
                    counter += number;
                    data.RemoveAt(index);
                    IncreaseDecreaseValueOfElements(data, number);
                }
                if (data.Count == 0)
                {
                    break;
                }
                index = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(counter);
        }

        public static List<int> IncreaseDecreaseValueOfElements(List<int> data, int number)
        {
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i] <= number)
                {
                    data[i] += number;
                }
                else
                {
                    data[i] -= number;
                }
            }
            return data;
        }
    }
}
