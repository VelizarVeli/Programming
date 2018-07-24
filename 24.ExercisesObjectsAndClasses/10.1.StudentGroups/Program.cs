using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _10._1.StudentGroups
{
    class Program
    {
        static void Main(string[] args)
        {

            var towns = new List<Town>();
            ReadTownsAndStudents(towns);
            List<Group> groups = DistributeStudentsIntoGroups(towns);

            Console.WriteLine("Created {0} groups in {1} towns:", groups.Count, towns.Count);

            foreach (Group group in groups.OrderBy(g => g.Town.Name))
            {
                Console.WriteLine("{0} => {1}", group.Town.Name, string.Join(", ", group.Students.Select(s => s.Email).ToList()));
            }
        }

        static List<Group> DistributeStudentsIntoGroups(List<Town> towns)
        {
            var groups = new List<Group>();
            foreach (var town in towns)
            {
                IEnumerable<Student> students = town.Students
                    .OrderBy(s => s.RegistrationDate).ThenBy(s => s.Name).ThenBy(s => s.Email);

                while (students.Any())
                {
                    var group = new Group();
                    group.Town = town;
                    group.Students = students.Take(group.Town.SeatsCount).ToList();
                    students = students.Skip(group.Town.SeatsCount);
                    groups.Add(group);
                }
            }
            return groups;
        }

        static List<Town> ReadTownsAndStudents(List<Town> towns)
        {
            string inputLine;
            while ((inputLine = Console.ReadLine()) != "End")
            {
                if (inputLine.Contains("=>"))
                {
                    var townObj = new Town();
                    string[] input1 = inputLine.Split(new[] { '=', '>' }, StringSplitOptions.RemoveEmptyEntries);
                    string town = input1[0].Trim();
                    string[] splitter = input1[1].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    int numberOfSeats = int.Parse(splitter[0]);
                    townObj.Name = town;
                    townObj.SeatsCount = numberOfSeats;
                    townObj.Students = new List<Student>();
                    towns.Add(townObj);
                }
                else
                {
                    var student = new Student();
                    string[] splitter2 = inputLine.Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                    string studName = splitter2[0].Trim();
                    string studEmail = splitter2[1].Trim();
                    var date = DateTime.ParseExact(splitter2[2].Trim(), "d-MMM-yyyy", CultureInfo.InvariantCulture);
                    student.Name = studName;
                    student.Email = studEmail;
                    student.RegistrationDate = date;
                    towns[towns.Count - 1].Students.Add(student);
                }
            }
            return towns;
        }

        public class Student
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public DateTime RegistrationDate { get; set; }
        }

        public class Town
        {
            public string Name { get; set; }
            public int SeatsCount { get; set; }
            public List<Student> Students { get; set; }
        }

        public class Group
        {
            public Town Town { get; set; }
            public List<Student> Students { get; set; }
        }
    }
}
