using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace _04.FixEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadAllLines(@"..\..\input.txt");
            File.Delete(@"..\..\output.txt");
            for (int i = 0; i < lines.Length; i += 2)
            {
                if (lines[i] == "stop" || lines[i + 1] == "stop")
                {
                    break;
                }

                var name = lines[i];
                var email = lines[i + 1];
                if (email.EndsWith(".uk") || email.EndsWith(".us"))
                {
                    continue;
                }
                var output = $"{name} -> {email}" + Environment.NewLine;
                File.AppendAllText(@"..\..\output.txt", output);
            }
        }
    }
}