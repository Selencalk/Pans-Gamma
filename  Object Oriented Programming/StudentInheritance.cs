using System;
using System.Collections.Generic;

namespace Csharpders
{
    public class Student
    {
        private string name;
        private string department;
        private double grade;
        private int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        public double Grade
        {
            get { return grade; }
            set { grade = value; }
        }

        public int Age
        {
            get { return age; }
        }

        static int GetRandomAge()
        {
            Random rnd = new Random();
            return rnd.Next(18, 30);
        }

        public Student(string pname, string pdept, double pgrade)
        {
            name = pname;
            department = pdept;
            grade = pgrade;
            age = GetRandomAge();
        }

        public virtual void IncreaseGrade(double percent)
        {
            grade = grade * (1 + percent / 100);
        }

        public static double AverageGrade(List<Student> students)
        {
            double total = 0;
            foreach (Student s in students)
            {
                total += s.Grade;
            }
            return total / students.Count;
        }

        public static void ShowStudents(List<Student> students)
        {
            foreach (Student s in students)
            {
                string type = s.GetType().Name;
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}",
                    s.Name, s.Department, Math.Round(s.Grade, 2), s.Age, type);
            }
        }
    }

    public class GraduateStudent : Student
    {
        private string thesisTopic;

        public string ThesisTopic
        {
            get { return thesisTopic; }
            set { thesisTopic = value; }
        }

        public GraduateStudent(string name, string dept, double grade, string topic)
            : base(name, dept, grade)
        {
            thesisTopic = topic;
        }

        public override void IncreaseGrade(double percent)
        {
            base.IncreaseGrade(percent);
            Grade += 5; // ekstra bonus
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            students.Add(new Student("Ali", "Computer Eng", 70));
            students.Add(new Student("Zeynep", "Math", 85));
            students.Add(new Student("Burak", "Physics", 60));

            GraduateStudent grad = new GraduateStudent(
                "Selen", "Computer Eng", 80, "Artificial Intelligence");

            students.Add(grad);

            Console.WriteLine("\n------ Student List ------\n");
            Student.ShowStudents(students);

            Console.WriteLine("\nAverage Grade (before): {0}",
                Math.Round(Student.AverageGrade(students), 2));

            foreach (Student s in students)
            {
                s.IncreaseGrade(10);
            }

            Console.WriteLine("\n------ After Grade Increase ------\n");
            Student.ShowStudents(students);

            Console.WriteLine("\nAverage Grade (after): {0}",
                Math.Round(Student.AverageGrade(students), 2));

            Console.WriteLine("\nGraduate Student Info:");
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}",
                grad.Name, grad.Department, grad.Grade, grad.Age, grad.ThesisTopic);
        }
    }
}
