using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoliTheCoder
{
    class RoliTheCoder
    {
        static void Main(string[] args)
        {
            List<Event> events = new List<Event>();

            string input = Console.ReadLine();

            while (!input.Equals("Time for Code"))
            {
                string[] eventInfo = input.Split(new char[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (isValidEvent(eventInfo) == false)
                {
                    input = Console.ReadLine();
                    continue;
                }

                string id = eventInfo[0];
                string name = eventInfo[1];
                List<string> participants = eventInfo.Skip(2).ToList();
                participants = participants.Distinct().ToList();

                Event currentEvent = ReadEvent(id, name, participants);

                if (events.Count == 0)
                {
                    events.Add(currentEvent);
                    continue;
                }
                else
                {
                    if (events.Any(e => e.ID.Equals(currentEvent.ID)))
                    {
                        Event tempEvent = events.First(e => e.ID.Equals(currentEvent.ID));
                        if (tempEvent.Name.Equals(currentEvent.Name))
                        {
                            foreach (string participant in currentEvent.participants)
                            {
                                if (!tempEvent.participants.Contains(participant))
                                {
                                    tempEvent.participants.Add(participant);
                                }
                            }
                        }
                    }
                    else
                    {
                        events.Add(currentEvent);
                    }
                }

                input = Console.ReadLine();
            }

            foreach (Event ev in events.OrderByDescending(e => e.participants.Count).ThenBy(e => e.Name))
            {
                Console.WriteLine("{0} - {1}", ev.Name.Substring(1, ev.Name.Length - 1), ev.participants.Count);
                foreach (string participant in ev.participants.OrderBy(p => p))
                {
                    Console.WriteLine(participant);
                }
            }
        }

        static Event ReadEvent(string id, string name, List<string> participants)
        {
            Event ev = new Event();
            ev.ID = id;
            ev.Name = name;
            ev.participants = participants;
            return ev;
        }

        static bool isValidEvent(string[] eventInfo)
        {
            if (eventInfo.Length < 2)
            {
                return false;
            }

            if (!eventInfo[1][0].Equals('#'))
            {
                return false;
            }

            for (int i = 2; i < eventInfo.Length; i++)
            {
                if (!eventInfo[i][0].Equals('@'))
                {
                    return false;
                }
            }
            return true;
        }

    }

    class Event
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public List<string> participants { get; set; }
    }
}