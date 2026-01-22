using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public static int Counter = 0;

    private string _name;
    private string _faculty;
    private int _grade;

    public string Name
    {
        get => _name;
        set => _name = value;
    }

    public string Faculty
    {
        get => _faculty;
        set => _faculty = value;
    }

    public int Grade
    {
        get => _grade;
        set
        {
            if (value < 0 || value > 100)
                throw new ArgumentException("Grade must be between 0 and 100!");
            _grade = value;
        }
    }

    public Student(string name, string faculty, int grade)
    {
        Name = name;
        Faculty = faculty;
        Grade = grade;
        Counter++;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Faculty: {Faculty}, Grade: {Grade}");
    }
}

class Program
{
    static Student FindBestStudent(List<Student> list)
    {
        if (list.Count == 0)
            return null;

        Student best = list[0];

        foreach (Student s in list)
        {
            if (s.Grade > best.Grade)
                best = s;
        }

        return best;
    }

    static void Main()
    {
        Random rnd = new Random();

        List<Student> students = new List<Student>()
        {
            new Student("Selen", "Engineering", rnd.Next(0, 101)),
            new Student("Melissa", "Economics", rnd.Next(0, 101)),
            new Student("David", "Health Science", rnd.Next(0, 101)),
            new Student("Zeynep", "Law", rnd.Next(0, 101)),
            new Student("Michael", "Computer Science", rnd.Next(0, 101))
        };

        students.Sort((s1, s2) =>
        {
            int nameCompare = s1.Name.CompareTo(s2.Name);   
            if (nameCompare == 0)
                return s2.Grade.CompareTo(s1.Grade);
            return nameCompare;
        });

        Console.WriteLine("Students (Sorted by Name and Grade):");
        foreach (var s in students)
            s.DisplayInfo();

        Console.WriteLine($"\nTotal student count: {Student.Counter}");

        double total = 0;
        foreach (var s in students)
            total += s.Grade;

        double avg = Math.Ceiling(total / students.Count);
        Console.WriteLine($"Average grade: {avg}");

        Student bestStudent = FindBestStudent(students);
        Console.WriteLine("\nBest student:");
        bestStudent.DisplayInfo();
    }
}