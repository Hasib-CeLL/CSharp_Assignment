using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 45, 89, 80, 15, 23, 24, 66, 49, 38, 77 };

        int sum = 0;
        int min = numbers[0];

        foreach (int num in numbers)
        {
            sum += num;
            if (num < min)
            {
                min = num;
            }
        }

        double average = (double)sum / numbers.Length;

        Console.WriteLine($"Average: {average}");
        Console.WriteLine($"Minimum value: {min}");
    }
}