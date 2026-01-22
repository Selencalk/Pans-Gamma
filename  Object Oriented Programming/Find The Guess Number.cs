using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Think of a number between 1 and 1000 (don’t tell me).");
        Console.WriteLine("The computer will try to guess it.");
        Console.WriteLine("If the guess is correct, type 'c'.");
        Console.WriteLine("If the guess is too high, type 'h'.");
        Console.WriteLine("If the guess is too low, type 'l'.\n");

        int min = 1;
        int max = 1000;
        int guess;
        int attempts = 0;
        string response = "";

        while (true)
        {
            guess = (min + max) / 2; 
            attempts++;
            Console.WriteLine($"Attempt {attempts}: My guess is {guess}");
            Console.Write("Is it correct (c), too high (h), or too low (l)? ");
            response = Console.ReadLine().ToLower();

            if (response == "c")
            {
                Console.WriteLine($"🎉 I found it in {attempts} attempts! Your number was {guess}.");
                break;
            }
            else if (response == "h")
            {
                max = guess - 1;
            }
            else if (response == "l")
            {
                min = guess + 1;
            }
            else
            {
                Console.WriteLine("Please enter only 'c', 'h', or 'l'!");
            }

            if (min > max)
            {
                Console.WriteLine("Hmm... something went wrong 😅");
                break;
            }
        }
    }
}
