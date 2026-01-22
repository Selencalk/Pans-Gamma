using System;
using System.Collections.Generic;

namespace OopInCsharp
{
    public class Person
    {
        public string Name { get; set; }
        public string Age { get; set; }

        public Person(string name, string age)
        {
            Name = name;
            Age = age;
        }
    }

    public class Employee : Person
    {
        public string Position { get; set; }
        public string Salary { get; set; }

        public static int Counter = 0;

        public Employee(string name, string age, string position, string salary)
            : base(name, age)
        {
            Position = position;
            Salary = salary;
            Counter++;
        }

        public static void ShowEmployees(List<Employee> workers)
        {
            foreach (Employee e in workers)
            {
                Console.WriteLine(
                    "Name: {0} \t Age: {1} \t Position: {2} \t Salary: {3}",
                    e.Name, e.Age, e.Position, e.Salary
                );
            }
        }
    }

    public class Boss : Employee
    {
        public string Department { get; set; }

        public Boss (string name, string age, string salary, string department)
            : base(name, age, "Boss", salary)
        {
            Department = department;
        }
    }

    class Program
    {
        static Random rnd = new Random();

        static string GetAge()
        {
            return rnd.Next(22, 35).ToString();
        }

        static void Main(string[] args)
        {
            List<Employee> workers = new List<Employee>();
            
            string[] names = { "Selen", "Zeynep", "Zehra", "Andrej" };
            string[] positions = { "Developer", "Tester", "Designer", "Boss" };
            string[] salaries = { "3000", "2800", "3200", "5000" };
            
            bool[] isBoss = { false, false, false, true };

            for (int i = 0; i < names.Length; i++)
            {
                if (isBoss[i] == true)                {
                    workers.Add(
                        new Boss(
                            names[i],
                            GetAge(),
                            salaries[i],
                            "IT"
                        )
                    );
                }
                else
                {
                    workers.Add(
                        new Employee(
                            names[i],
                            GetAge(),
                            positions[i],
                            salaries[i]
                        )
                    );
                }
            }

            Employee.ShowEmployees(workers);

            Console.WriteLine("\nTotal Employees: " + Employee.Counter);
        }
    }
}
