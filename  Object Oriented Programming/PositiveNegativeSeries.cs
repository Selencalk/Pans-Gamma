using System;

class AlternatingSeries
{
    static void Main()
    {
        int limit = 10;

        for (int i = 1; i <= limit; i++)
        {
            if (i % 2 == 1)
            {
                Console.Write(i + " ");
            }
            else
            {
                Console.Write(-i + " ");
            }
        }
    }
}
