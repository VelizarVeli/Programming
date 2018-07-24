using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _08.Mentor_Group
{
    class Student
    {
        public string Name { get; set; }
        public List<string> Comment { get; set; }
        public List<DateTime> Date { get; set; }
    }
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var nameDate = new Dictionary<string, List<DateTime>>();
            while (input != "end of dates")
            {
                var tokens = input.Split(' ', ',');
                var name = tokens[0];
                if (tokens.Length == 1)// ako ima samo ime
                {
                    nameDate[name] = new List<DateTime>();
                    input = Console.ReadLine();
                    continue;
                }
                var dates = tokens.Skip(1).Select(a => DateTime.ParseExact(a, "dd/MM/yyyy", CultureInfo.InvariantCulture)).ToList();

                if (!nameDate.ContainsKey(name))
                {
                    nameDate[name] = new List<DateTime>();
                }
                nameDate[name].AddRange(dates);
                input = Console.ReadLine();
            }

            var inputCommant = Console.ReadLine();
            var nameCommand = new Dictionary<string, List<string>>();
            while (!inputCommant.Equals("end of comments"))
            {
                var tokensCommand = inputCommant.Split('-');
                var student = tokensCommand[0];
                if (tokensCommand.Length == 1)// ako ima samo ime
                {
                    if (!nameDate.ContainsKey(student))
                    {
                        inputCommant = Console.ReadLine();
                        continue;
                    }
                    nameCommand[student] = new List<string>();
                    inputCommant = Console.ReadLine();
                    continue;
                }
                var comment = tokensCommand[1];
                if (!nameDate.ContainsKey(student))
                {
                    inputCommant = Console.ReadLine();
                    continue;
                }

                if (!nameCommand.ContainsKey(student))
                {
                    nameCommand[student] = new List<string>();
                }
                nameCommand[student].Add(comment);
                inputCommant = Console.ReadLine();
            }
            var studentList = new List<Student>();
            foreach (var student in nameDate)
            {
                var name = student.Key;
                var dates = student.Value;
                List<string> studentComments = new List<string>();
                if (nameCommand.ContainsKey(name))
                {
                    studentComments = nameCommand[name];
                }
                Student currentStudent = new Student()
                {
                    Name = name,
                    Date = dates,
                    Comment = studentComments
                };
                studentList.Add(currentStudent);
            }

            foreach (var student in studentList.OrderBy(x => x.Name))
            {
                Console.WriteLine(student.Name);
                Console.WriteLine("Comments:");
                if (student.Comment.Count > 0)
                {
                    foreach (var comment in student.Comment)
                        Console.WriteLine($"- {comment}");
                }
                Console.WriteLine("Dates attended:");
                if (student.Date.Count > 0)
                {
                    foreach (var date in student.Date.OrderBy(x => x.Date))
                    {
                        Console.WriteLine($"-- {date:dd/MM/yyyy}");
                    }
                }
            }
        }
    }
}