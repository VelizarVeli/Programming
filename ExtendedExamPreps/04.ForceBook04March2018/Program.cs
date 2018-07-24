using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
//за два часа 70/100
namespace _04.ForceBook04March2018
{
    class Program
    {
        static void Main()
        {
            string input;

            Dictionary<string, string> forceData = new Dictionary<string, string>();

            string lightName = String.Empty;
            string darkName = String.Empty;

            while ((input = Console.ReadLine()) != "Lumpawaroo")
            {
                string[] inp1 = Regex.Split(input, @" \| ");
                string[] inp2 = Regex.Split(input, @" -> ");

                if (inp1.Length == 2)
                {
                    string user = inp1[1];
                    string side = inp1[0];

                    if (!forceData.ContainsKey(user))
                    {
                        forceData.Add(user, side);
                    }
                }

                else if (inp2.Length == 2)
                {
                    string user = inp2[0];
                    string side = inp2[1];

                    if (!forceData.ContainsKey(user))
                    {
                        forceData.Add(user, side);

                        Console.WriteLine($"{user} joins the {side} side!");
                    }
                    else
                    {
                        if (side != forceData[user])
                        {
                            Console.WriteLine($"{user} joins the {side} side!");
                        }
                        forceData[user] = side;
                    }
                }
            }
            foreach (var nam in forceData)
            {
                lightName = nam.Value;
                break;
            }

            foreach (var nam in forceData)
            {
                if (nam.Value != lightName)
                {
                    darkName = nam.Value;
                    break;
                }
            }
            List<string> dark = new List<string>();
            List<string> light = new List<string>();

            foreach (var name in forceData)
            {
                if (name.Value == darkName)
                {
                    dark.Add(name.Key);
                }
                else
                {
                    light.Add(name.Key);
                }
            }

            if (dark.Count == light.Count)
            {
                string current = darkName;
                darkName = lightName;
                lightName = current;

                List<string> curr = new List<string>();
                curr = dark;
                dark = light;
                light = curr;
            }
            if (dark.Count < light.Count)
            {
                if (lightName != string.Empty)
                {
                    Console.WriteLine($"Side: {lightName}, Members: {light.Count}");
                    foreach (var lightNam in light.OrderBy(a => a))
                    {
                        Console.WriteLine($"! {lightNam}");
                    }
                }

                if (darkName != string.Empty)
                {
                    Console.WriteLine($"Side: {darkName}, Members: {dark.Count}");
                    foreach (var darkNam in dark.OrderBy(a => a))
                    {
                        Console.WriteLine($"! {darkNam}");
                    }
                }
            }

            else
            {
                if (darkName != string.Empty)
                {
                    Console.WriteLine($"Side: {darkName}, Members: {dark.Count}");
                    foreach (var darkNam in dark.OrderBy(a => a))
                    {
                        Console.WriteLine($"! {darkNam}");
                    }
                }

                if (lightName != string.Empty)
                {
                    Console.WriteLine($"Side: {lightName}, Members: {light.Count}");
                    foreach (var lightNam in light.OrderBy(a => a))
                    {
                        Console.WriteLine($"! {lightNam}");
                    }
                }
            }
        }
    }
}
