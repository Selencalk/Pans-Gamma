using System;

class FactorialExample
{
    static long FactorialFor(int n)
    {
        long result = 1;

        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }

        return result;
    }

    static long FactorialWhile(int n)
    {
        long result = 1;
        int i = 1;

        while (i <= n)
        {
            result *= i;
            i++;
        }

        return result;
    }

    static void Main()
    {
        Console.WriteLine("5! (for loop)   = " + FactorialFor(5));
        Console.WriteLine("5! (while loop) = " + FactorialWhile(5));
    }
}
