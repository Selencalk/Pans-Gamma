using System;

class Employee
{
    public string Name { get; set; }
    public string Position { get; set; }
    public string Salary { get; set; }
    public string Age { get; set; }

    public Employee(string name, string position, string salary, string age)
    {
        Name = name;
        Position = position;
        Salary = salary;
        Age = age;
    }
}

class Program
{
    static string getNum()
    {
        Random random = new Random();
        int num;
        num = random.Next(20, 65);
        return num.ToString();
    }

    public static void Main(string[] args)
    {
        string randomAge = getNum();

        Employee emp1 = new Employee("Selen", "Manager", "5000", randomAge);

        Console.WriteLine("Name: " + emp1.Name);
        Console.WriteLine("Position: " + emp1.Position);
        Console.WriteLine("Salary: " + emp1.Salary);
        Console.WriteLine("Age: " + emp1.Age);
    }
}
