using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._5.ForceBook04March2018OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ForceUser> forceUsers = new List<ForceUser>();

            string input;

            while ((input = Console.ReadLine()) != "Lumpawaroo")
            {
                if (input.Split(new[] { ' ', '|' }, StringSplitOptions.RemoveEmptyEntries).Length == 2)
                {
                    string[] inp = input.Split(new[] { ' ', '|' }, StringSplitOptions.RemoveEmptyEntries);
                    string forceSide = inp[0];
                    string forceUser = inp[1];

                    if (!forceUsers.Any(a => a.Name == forceUser))
                    {
                        ForceUser currentForceUser = new ForceUser(forceUser, forceSide);
                        forceUsers.Add(currentForceUser);
                    }
                }
                else if (input.Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).Length == 2)
                {
                    string[] inp = input.Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                    string forceUser = inp[0];
                    string forceSide = inp[1];

                    if (forceUsers.Any(a => a.Name == forceUser))
                    {
                        var currentForceUser = forceUsers.FirstOrDefault(a => a.Equals(forceUser));
                        currentForceUser.Side = forceSide;

                    }
                    else if (!forceUsers.Any(a => a.Name == forceUser))
                    {
                        ForceUser currentForceUser = new ForceUser(forceUser, forceSide);
                        forceUsers.Add(currentForceUser);
                    }
                    Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                }
            }

            List<>

            if (forceUsers.Count != 0)
            {
                foreach (var user in forceUsers.Where(a => a.Side.Count))
                {
                 dd   
                }
            }
        }

        public abstract class ForceUser
        {
            public string Name { get; set; }
            public string Side { get; set; }

            public ForceUser(string name, string side)
            {
                this.Name = name;
                this.Side = side;
            }


        }

        public class DarkSide : ForceUser
        {
            public DarkSide(string name, string side) : base(name, side)
            {
            }
        }

        public class LightSide :ForceUser
        {
            public LightSide(string name, string side) : base(name, side)
            {
            }
        }
    }
}
