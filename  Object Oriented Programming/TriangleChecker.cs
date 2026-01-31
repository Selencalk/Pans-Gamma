using System;

class TriangleChecker
{
    static void Main()
    {
        Console.WriteLine("Enter side A:");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter side B:");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter side C:");
        int c = Convert.ToInt32(Console.ReadLine());

        // Triangle rule
        if (a + b > c && a + c > b && b + c > a)
        {
            Console.WriteLine("You can make a triangle.");

            // Right triangle check (Pythagorean theorem)
            if (a * a + b * b == c * c ||
                a * a + c * c == b * b ||
                b * b + c * c == a * a)
            {
                Console.WriteLine("It is a right-angled triangle.");
            }
            else
            {
                Console.WriteLine("It is NOT a right-angled triangle.");
            }
        }
        else
        {
            Console.WriteLine("You cannot make a triangle.");
        }
    }
}
