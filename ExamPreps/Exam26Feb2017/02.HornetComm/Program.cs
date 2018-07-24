using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> privateMessage = new List<string>();
            List<string> broadcast = new List<string>();
            while (input != "Hornet is Green")
            {

                string[] input1 = input.Split(new string[] { " <-> " }, StringSplitOptions.RemoveEmptyEntries);
                string first = input1[0];
                string second = input1[1];


                if (first.All(char.IsDigit) && (second.All(char.IsLetterOrDigit)))
                {
                    //private message
                    first = ReverseString(first);
                    string storedInList = first + " -> " + second;
                    privateMessage.Add(storedInList);
                }
                else if (!first.All(char.IsDigit) && (second.All(char.IsLetterOrDigit)))
                {
                    //broadcast
                    StringBuilder result = new StringBuilder();
                    for (int i = 0; i < second.Length; i++)
                    {
                        if (char.IsUpper(second, i))
                            result.Append(char.ToLower(second[i]));
                        else if (char.IsLower(second, i))
                            result.Append(char.ToUpper(second[i]));
                        else
                            result.Append(second[i]);
                    }
                    string storedInList = result + " -> " + first;
                    broadcast.Add(storedInList);
                }
                input = Console.ReadLine();
            }

            if (broadcast.Count > 0)
            {
                Console.WriteLine("Broadcasts:");
                Console.WriteLine(string.Join("\n", broadcast));
            }
            else
            {
                Console.WriteLine("Broadcasts:");
                Console.WriteLine("None");
            }

            if (privateMessage.Count > 0)
            {
                Console.WriteLine("Messages:");
                Console.WriteLine(string.Join("\n", privateMessage));
            }
            else
            {
                Console.WriteLine("Messages:");
                Console.WriteLine("None");
            }

        }
        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
