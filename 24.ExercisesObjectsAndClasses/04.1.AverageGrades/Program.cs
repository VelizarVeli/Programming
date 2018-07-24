using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._1.AverageGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> above5 = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                Student stud = CollectStudents(input);
                if (stud.AverageGrade >= 5)
                {
                    above5.Add(stud);
                }
            }

            foreach (var student in above5.OrderBy(a => a.Name).ThenByDescending(a => a.AverageGrade))
            {
                Console.WriteLine($"{student.Name} -> {student.AverageGrade:f2}");
            }
        }

        public static Student CollectStudents(string[] input)
        {
            Student student = new Student();
            student.Name = input[0];
            student.Grades = new List<double>();
            for (int i = 1; i < input.Length; i++)
            {
                student.Grades.Add(double.Parse(input[i]));
            }

            return student;
        }

        public double GetAverage(double aver)
        {
            return aver;
        }

        public class Student
        {
            public string Name { get; set; }
            public List<double> Grades { get; set; }
            public double AverageGrade
            {
                get
                {
                    return Grades.Average();
                }
            }
        }
    }
}
