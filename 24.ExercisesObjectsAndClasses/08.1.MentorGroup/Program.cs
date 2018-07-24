using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _08._1.MentorGroup
{
    class Program
    {
        static void Main()
        {
            SortedDictionary<string, Student> students = new SortedDictionary<string, Student>();
            string input;
            while ((input = Console.ReadLine()) != "end of dates")
            {
                string[] attendanceDates = input.Split();
                string name = attendanceDates[0];
                if (!students.ContainsKey(name))
                {
                    students.Add(name, new Student());
                }
                if (attendanceDates.Length == 1)
                {
                    continue;
                }

                string[] datesAtt = attendanceDates[1].Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var stud in datesAtt)
                {
                    var dateExact = DateTime.ParseExact(stud, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    students[name].DatesAttended.Add(dateExact);
                }
            }

            while ((input = Console.ReadLine()) != "end of comments")
            {
                string[] inp = input.Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                string name = inp[0];
                if (students.ContainsKey(name))
                {
                    students[name].Comments.Add(inp[1]);
                }
            }

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Key}");
                Console.WriteLine("Comments:");
                foreach (var comments in student.Value.Comments)
                {
                    Console.WriteLine($"- {comments}");
                }

                Console.WriteLine("Dates attended:");
                foreach (var date in student.Value.DatesAttended.OrderBy(a => a))
                {
                    Console.WriteLine($"-- {date:dd/MM/yyy}");
                }
            }
        }

        public class Student
        {
            public List<DateTime> DatesAttended { get; set; }
            public List<string> Comments { get; set; }

            public Student()
            {
                this.DatesAttended = new List<DateTime>();
                this.Comments = new List<string>();
            }
        }
    }
}
