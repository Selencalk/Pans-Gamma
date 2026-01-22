using System;

public class WallisPiCalculator
{
    public static void Main(string[] args)
    {

        int numberOfTerms = 100;

        double piApproximation = CalculatePiUsingWallis(numberOfTerms);

        Console.WriteLine($"Number of Terms Used: {numberOfTerms}");
        Console.WriteLine($"Pi Approach Calculated by Wallis Multiplication: {piApproximation}");
        Console.WriteLine($"Math.PI Value: {Math.PI}");
        Console.WriteLine($"Error: {Math.Abs(piApproximation - Math.PI)}");
    }

    public static double CalculatePiUsingWallis(int n)
    {
        if (n <= 0)
        {
            return 0.0; 
        }

        double product = 1.0;

        for (int i = 1; i <= n; i++)
        {
            double numerator = 4.0 * i * i;
            double denominator = numerator - 1.0;
            
            product *= (numerator / denominator);
        }

        return 2.0 * product;
    }
}