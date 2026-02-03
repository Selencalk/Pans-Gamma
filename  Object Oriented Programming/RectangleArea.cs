using System;
using System.Collections.Generic;
using System.Linq;

public class Figure
{
    protected int dimension;

    public Figure(int dimension)
    {
        this.dimension = dimension;
    }

    public virtual double GetArea()
    {
        return 0;
    }

    public virtual string GetDescription()
    {
        return "Line";
    }
}

public class Rectangle : Figure
{
    private double width;
    private double length;

    public Rectangle(double width, double length) : base(2)
    {
        this.width = width;
        this.length = length;
    }

    public double GetWidth()
    {
        return width;
    }

    public double GetLength()
    {
        return length;
    }

    public override double GetArea()
    {
        return width * length;
    }

    public override string GetDescription()
    {
        return $"Rectangle ({width}x{length})";
    }
}

class Program
{
    static void Main()
    {
        List<Figure> figures = new List<Figure>
        {
            new Figure(1),
            new Rectangle(4, 5),
            new Rectangle(9, 6),
            new Rectangle(7, 10)
        };

        Console.WriteLine("Figures:\n");

        foreach (var f in figures)
        {
            Console.WriteLine($"{f.GetDescription()} → Area: {f.GetArea()}");
        }

        double averageArea = figures.Average(f => f.GetArea());

        Console.WriteLine($"\nAverage area: {averageArea}");
    }
}
