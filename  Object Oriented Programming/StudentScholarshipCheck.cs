using System;
using System.Collections.Generic;

public class Program
{
    // Delegate with multiple parameters
    delegate string ScholarshipStatus(Student s, int minScore);

    public static void Main()
    {
        ScholarshipStatus checkScholarship =
            (s, min) => s.Marks >= min
            ? s.Name + " is eligible for scholarship."
            : s.Name + " is not eligible for scholarship.";

        List<Student> students = new List<Student>()
        {
            new Student { Name = "Anna", Marks = 85 },
            new Student { Name = "John", Marks = 72 },
            new Student { Name = "Maria", Marks = 90 }
        };

        foreach (Student s in students)
        {
            Console.WriteLine(checkScholarship(s, 80));
        }
    }
}

public class Student
{
    public string Name { get; set; }
    public int Marks { get; set; }
}