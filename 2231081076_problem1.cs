using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter two numbers separated by a space:");
        string input = Console.ReadLine();
        
        string[] numbers = input.Split(' ');
        
        if (numbers.Length != 2)
        {
            Console.WriteLine("Invalid input. Please enter exactly two numbers separated by a space.");
            return;
        }
        
        if (!double.TryParse(numbers[0], out double num1) || !double.TryParse(numbers[1], out double num2))
        {
            Console.WriteLine("Invalid input. Please enter valid numbers.");
            return;
        }
        
        double addition = num1 + num2;
        double subtraction = num1 - num2;
        double multiplication = num1 * num2;
        double division = num1 / num2;
        
        Console.WriteLine($"{num1} + {num2} = {addition}");
        Console.WriteLine($"{num1} - {num2} = {subtraction}");
        Console.WriteLine($"{num1} * {num2} = {multiplication}");
        Console.WriteLine($"{num1} / {num2} = {division}");
    }
}