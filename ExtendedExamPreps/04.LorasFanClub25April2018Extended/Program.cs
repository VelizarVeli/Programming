using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.LorasFanClub25April2018Extended
{
    class Program
    {
        static void Main()
        {
            string input;

            List<Candidate> candidates = new List<Candidate>();

            while ((input = Console.ReadLine()) != "Make a decision already!")
            {
                string[] inp = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string name = inp[0];
                string trait = inp[1];

                if (inp[1] == "does" && inp[2] == "Gyubek!")
                {
                    Candidate candidate = candidates.FirstOrDefault(a => a.Name == name);
                    if (candidate != null)
                    {
                        foreach (var trai in candidate.TraitValue.ToList())
                        {
                            string currentTraitName = trai.Key;
                            int currentTraitValue = trai.Value;

                            if (currentTraitValue > 0)
                            {
                                candidate.TraitValue[currentTraitName] = 0;
                            }
                        }
                    }
                }

                else
                {
                    int traitValue = int.Parse(inp[2]);
                    Candidate candidate = candidates.FirstOrDefault(a => a.Name.Equals(name));
                    if (candidate == null)
                    {
                        candidate = new Candidate(name, trait, CheckTraits(trait, traitValue));
                        candidates.Add(candidate);
                    }
                    else
                    {
                        traitValue = CheckTraits(trait, traitValue);
                        if (candidate.TraitValue.ContainsKey(trait))
                        {
                            if (traitValue > candidate.TraitValue[trait])
                            {
                                candidate.TraitValue[trait] = traitValue;
                            }
                        }
                        else
                        {
                            candidate.TraitValue.Add(trait, traitValue);
                        }
                    }
                }
            }

            foreach (var candidate in candidates.OrderByDescending(a => a.TraitValue.Values.Sum()).ThenBy(a => a.Name))
            {
                Console.WriteLine($"# {candidate.Name}: {candidate.TraitValue.Values.Sum()}");

                foreach (var trait in candidate.TraitValue.OrderByDescending(a => a.Value))
                {
                    if (trait.Value != 0)
                    {
                        Console.WriteLine($"!!! {trait.Key} -> {trait.Value}");
                    }
                }
            }
        }

        private static int CheckTraits(string trait, int traitValue)
        {
            switch (trait)
            {
                case "Greedy":
                    traitValue *= -1;
                    break;
                case "Rude":
                    traitValue *= -1;
                    break;
                case "Dumb":
                    traitValue *= -1;
                    break;
                case "Kind":
                    traitValue *= 2;
                    break;
                case "Handsome":
                    traitValue *= 3;
                    break;
                case "Smart":
                    traitValue *= 5;
                    break;
            }

            return traitValue;
        }

        public class Candidate
        {
            public string Name { get; set; }
            public Dictionary<string, int> TraitValue { get; set; }

            public Candidate(string name, string trait, int value)
            {
                this.Name = name;
                this.TraitValue = new Dictionary<string, int>();
                TraitValue.Add(trait, value);
            }
        }
    }
}
