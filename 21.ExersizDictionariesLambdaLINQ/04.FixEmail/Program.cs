using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FixEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, string> contacts = new Dictionary<string, string>();
            while (input != "stop")
            {
                string currentName = input;
                input = Console.ReadLine();
                string check = input.Substring(input.Length - 2).ToLower();
                if (check != "us" && check != "uk")
                {
                    contacts[currentName] = input;
                }
                input = Console.ReadLine();
            }
            foreach (var name in contacts)
            {
                Console.WriteLine($"{name.Key} -> {name.Value}");
            }
        }
    }
}
