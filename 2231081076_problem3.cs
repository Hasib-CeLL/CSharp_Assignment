using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number (n):");
        if (!int.TryParse(Console.ReadLine(), out int n) || n < 0)
        {
            Console.WriteLine("Invalid input. Please enter a non-negative integer.");
            return;
        }

        for (int i = n; i >= 0; i--)
        {
            Console.Write(i);
            if (i != 0)
                Console.Write(" ");
        }

    }
}