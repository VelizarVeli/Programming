using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();
            while (input[0] != "END")
            {
                if (input[0] == "A")
                {
                    phonebook[input[1]] = input[2];
                }
                else
                {


                    if (input[0] == "ListAll")
                        {
                            foreach (var key in phonebook)
                            {
                                Console.WriteLine($"{key.Key} -> {key.Value}");
                            }
                        }
                        else if (phonebook.ContainsKey(input[1]))
                        {
                            Console.WriteLine(input[1] + " -> " + phonebook[input[1]]);
                        }
                        else
                        {
                            Console.WriteLine($"Contact {input[1]} does not exist.");
                        }
                }
                input = Console.ReadLine().Split(' ').ToArray();
            }
        }
    }
}
