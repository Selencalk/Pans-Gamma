using System;

class PiApproximation
{
    // Leibniz formula
    static double CalculatePiLeibniz(int iterations)
    {
        double sum = 0;
        int sign = 1;

        for (int i = 1; i <= iterations; i += 2)
        {
            sum += sign * (1.0 / i);
            sign *= -1;
        }

        return 4 * sum;
    }

    // Euler formula
    static double CalculatePiEuler(int iterations)
    {
        double sum = 0;

        for (int i = 1; i <= iterations; i++)
        {
            sum += 1.0 / (i * i);
        }

        return Math.Sqrt(6 * sum);
    }

    // Wallis product
    static double CalculatePiWallis(int iterations)
    {
        double product = 1;

        for (int i = 1; i <= iterations; i++)
        {
            product *= (2.0 * i / (2 * i - 1)) * (2.0 * i / (2 * i + 1));
        }

        return 2 * product;
    }

    // Iteration finder
    static int FindIterations(Func<int, double> method, double realPi, double tolerance)
    {
        int i = 1;
        double diff;

        do
        {
            diff = method(i) - realPi;
            i++;
        } while (Math.Abs(diff) >= tolerance);

        return i;
    }

    static void Main()
    {
        double realPi = Math.PI;
        int iterations = 100;
        double tolerance = 0.1;

        Console.WriteLine("Pi approximation after {0} iterations:\n", iterations);

        Console.WriteLine("Leibniz: {0}", CalculatePiLeibniz(iterations));
        Console.WriteLine("Euler:   {0}", CalculatePiEuler(iterations));
        Console.WriteLine("Wallis:  {0}\n", CalculatePiWallis(iterations));

        Console.WriteLine("Iterations needed for difference < {0}:\n", tolerance);

        Console.WriteLine("Leibniz: {0}",
            FindIterations(CalculatePiLeibniz, realPi, tolerance));

        Console.WriteLine("Euler:   {0}",
            FindIterations(CalculatePiEuler, realPi, tolerance));

        Console.WriteLine("Wallis:  {0}",
            FindIterations(CalculatePiWallis, realPi, tolerance));
    }
}
