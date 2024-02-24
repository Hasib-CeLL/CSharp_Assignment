using System;

class Program
{
    static void Main(string[] args)
    {
        int sum = 0;

        for (int i = 5; i <= 500; i += 5)
        {
            sum += i;
        }

        Console.WriteLine("Summation of the series: " + sum);
    }
}