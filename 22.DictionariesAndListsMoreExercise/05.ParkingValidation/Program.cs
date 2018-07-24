using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05.ParkingValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            Dictionary<string, string> data = new Dictionary<string, string>();
            for (int i = 0; i < N; i++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                string command = input[0];
                string username = input[1];
                string licencePlate = "";
                bool check = false;

                try
                {
                    licencePlate = input[2];
                }
                catch (Exception)
                {
                    goto Found;
                }

                string firstAndLast = licencePlate.Remove(2, 4);
                string digits = licencePlate.Substring(2, 4);
                try
                {
                    int digitsCheck = int.Parse(digits);
                }
                catch (Exception)
                {
                    check = true;
                }
                if (licencePlate.Length != 8)
                {
                    check = true;
                }
                else if (!Regex.IsMatch(firstAndLast, @"^[A-Z]+$"))
                {
                    check = true;
                }
                Found:
                if (check)
                {
                    Console.WriteLine($"ERROR: invalid license plate {licencePlate}");
                }
                else
                {
                    if (command == "register")
                    {
                        if (data.ContainsValue(licencePlate))
                        {
                            Console.WriteLine($"ERROR: license plate {licencePlate} is busy");
                        }
                        if (!data.ContainsKey(username))
                        {
                            data.Add(username, licencePlate);
                            Console.WriteLine($"{ username} registered { licencePlate} successfully");
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {licencePlate}");
                        }
                        
                    }
                    else 
                    {                    
                        if (!data.ContainsKey(username))
                        {
                            Console.WriteLine($"ERROR: user {username} not found");
                        }
                        else
                        {
                            data.Remove(username);
                            Console.WriteLine($"user {username} unregistered successfully");
                        }
                    }
                }
            }
            foreach (var item in data)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
