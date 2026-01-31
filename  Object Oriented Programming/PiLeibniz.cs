using System;

class PiLeibniz
{
    static void Main()
    {
        double sum = 0.0;
        double realPi = 3.141592;
        int sign = 1;
        int terms = 1_000_000;

        for (int i = 1; i <= terms; i++)
        {
            sum += sign * (1.0 / (2 * i - 1));
            sign *= -1;
        }

        double calculatedPi = 4 * sum;

        Console.WriteLine("pi = " + calculatedPi);
        Console.WriteLine("diff = " + (calculatedPi - realPi));
    }
}
