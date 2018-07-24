namespace _08_AverageGrades
{
    using System.Linq;

    public class Student
    {
        public string Name { get; set; }
        public double[] Grades { get; set; }
        public double AverageGrade => Grades.Average();
    }
}