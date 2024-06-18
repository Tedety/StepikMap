using System.Collections.Generic;
using static StepikMap.FlagColor;

namespace StepikMap
{
    public class Student
    {
        public static List<Student> Students = new List<Student>();
        public string Name { get; set; }
        public string Surname { get; set; }
        public double[] Points { get; set; }
        public FlagColor Color {  get; set; }

        public Student(string name, string surname, double[] points, FlagColor color)
        {
            Name = name;
            Surname = surname;
            Points = points;
            Color = color;
        }
    }
}
