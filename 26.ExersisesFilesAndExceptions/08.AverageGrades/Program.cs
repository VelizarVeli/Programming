namespace _08_AverageGrades
{
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            var studentsList = new List<Student>();

            var input = File.ReadAllLines(@"..\..\Input.txt");
            var indexer = 0;

            int studentsCount = int.Parse(input[indexer++]);

            for (int i = 1; i < studentsCount; i++)
            {
                string[] studentInfo = input[indexer++]
                    .Split(' ')
                    .ToArray();

                double[] grades = studentInfo
                    .Skip(1)
                    .Select(double.Parse)
                    .ToArray();

                var currentStudent = new Student
                {
                    Name = studentInfo[0],
                    Grades = grades
                };

                studentsList.Add(currentStudent);
            }

            var filteredStudents = studentsList
                .Where(avg => avg.AverageGrade >= 5.00)
                .OrderBy(n => n.Name)
                .ThenByDescending(g => g.AverageGrade)
                .ToList();

            var result = new List<string>();

            foreach (var student in filteredStudents)
            {
                result.Add($"{student.Name} -> {student.AverageGrade:f2}");
            }

            File.WriteAllLines(@"..\..\Output.txt", result);

        }
    }
}