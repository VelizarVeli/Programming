using System;
using System.Text.RegularExpressions;

namespace _03.CameraView
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = new Regex(@"(?<=\s)[a-z0-9]+([-.]\w*)*@[a-z]+([-.]\w*)*(\.[a-z]+)");
            var text = Console.ReadLine();
            var emails = regex.Matches(text);
            foreach (Match email in emails)
            {
                Console.WriteLine(email);
            }
        }
    }
}

