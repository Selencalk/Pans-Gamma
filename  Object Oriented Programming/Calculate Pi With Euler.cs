using System;

class Program
{
    static void Main()
    {
        Console.Write("How many terms should be used: ");
        int n = int.Parse(Console.ReadLine());

        double pi = CalculatePiEuler(n);
        Console.WriteLine($"Approximate Pi Value ({n} term): {pi}");
    }

    static double CalculatePiEuler(int terms)
    {
        double sum = 0;

        for (int i = 1; i <= terms; i++)
        {
            sum += 1.0 / (i * i);
        }

        return Math.Sqrt(6 * sum);
    }
}
