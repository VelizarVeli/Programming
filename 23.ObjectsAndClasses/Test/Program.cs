using System;
using System.Collections.Generic;
using System.Linq;

namespace Roli_The_Coder
{

    class Program
    {
        static void Main()
        {
            var bookOfEvents = new Dictionary<int, Dictionary<string, List<string>>>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Time for Code")
                {
                    break;
                }

                string[] input = line.Split();

                if (!input[1].StartsWith('#'))
                {
                    continue;
                }

                int counter = 0;
                for (int i = 2; i < input.Length; i++)
                {
                    if (!input[i].StartsWith('@'))
                    {
                        counter++;
                    }
                }

                if (counter > 0)
                {
                    continue;
                }

                int id = int.Parse(input[0]);
                string eventName = input[1];


                if (!bookOfEvents.ContainsKey(id))
                {
                    bookOfEvents[id] = new Dictionary<string, List<string>>();

                    var participantsBook = new Dictionary<string, List<string>>();

                    participantsBook[eventName] = new List<string>();

                    var participants = new List<string>();

                    for (int i = 2; i < input.Length; i++)
                    {
                        participants.Add(input[i]);
                    }

                    participantsBook[eventName] = participants;

                    bookOfEvents[id] = participantsBook;
                }
                else
                {
                    var existingId = bookOfEvents[id];

                    foreach (var item in existingId)
                    {
                        if (item.Key == eventName)
                        {
                            var newParticipationsBook = new Dictionary<string, List<string>>();

                            newParticipationsBook[eventName] = new List<string>();

                            var newParticipations = new List<string>();
                            for (int i = 2; i < input.Length; i++)
                            {
                                newParticipations.Add(input[i]);
                            }

                            newParticipationsBook[eventName] = newParticipations;

                            bookOfEvents[id] = newParticipationsBook;
                        }
                    }
                }
            }


            var sortedDic = new Dictionary<string, List<string>>();

            foreach (var item in bookOfEvents)
            {

                foreach (var s in item.Value)
                {
                    sortedDic[s.Key] = s.Value;
                }
            }

            foreach (var item in sortedDic.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {

                Console.WriteLine($"{item.Key.Substring(1, item.Key.Count() - 1)} - {item.Value.Count}");
                foreach (var p in item.Value)
                {
                    Console.WriteLine(p);
                }
            }


        }
    }
}