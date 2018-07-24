using System;
using System.Linq;
using System.Collections.Generic;
using System.Dynamic;

namespace Roli_The_Coder
{
    public class Program
    {
        public static void Main()
        {
            Dictionary<string, int> check = new Dictionary<string, int>();
            check.Add("checky", 23);
            check["checky"] = 24;
        }
    }

    public class Event
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}