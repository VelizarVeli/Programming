using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> data = new Dictionary<string, List<double>>();
            for (int i = 0; i < N; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                string name = input[0];
                double grade = double.Parse(input[1]);
                if (!data.ContainsKey(name))
                {
                    data.Add(name,new List<double>());
                }
                data[name].Add(grade);
            }
            foreach (KeyValuePair<string, List<double>> name in data)
            {
                string nam = name.Key;
                List<double> grad = name.Value;
                grad = grad.Select(a => Math.Round(a, 2)).ToList();
                var average = grad.Average();

                Console.Write($"{nam} -> ");
                foreach (double grade in grad)
                {
                    Console.Write($"{grade:F2} ");
                }
                Console.WriteLine($"(avg: {average:f2})");
                //това долу е същото като горният ред
                //var average = grad.Sum(x => Convert.ToDouble(x));
                //average /= grad.Count;

                /*
                 форматиране до втората цифра след десетичната запетая използвайки string.Join и LINQ
                Console.WriteLine("{0} -> {1} (avg: {2:f2})", nam, string.Join(" ", grad.Select(g => string.Format("0:F2", g)).ToArray()), average);
                */

            }
        }
    }
}
