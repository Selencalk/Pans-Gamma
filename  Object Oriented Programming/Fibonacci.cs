using System;

class FibonacciExample
{
    static void Main()
    {
        Console.Write("Enter how many Fibonacci numbers you want: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int first = 0;
        int second = 1;

        Console.WriteLine("Fibonacci Series:");

        for (int i = 0; i < n; i++)
        {
            Console.Write(first + " ");
            int next = first + second;
            first = second;
            second = next;
        }

        Console.WriteLine();
    }
}
