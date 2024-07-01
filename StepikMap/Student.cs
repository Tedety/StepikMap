using System.Collections.Generic;

namespace StepikMap
{
    public class Student
    {
        public static List<Student> Students = new List<Student>();
        public string Name;
        public string Surname;
        public double[] Points;
        public FlagColor Color;

        public Student(string name, string surname, double[] points, FlagColor color)
        {
            Name = name;
            Surname = surname;
            Points = points;
            Color = color;
        }
    }
}
