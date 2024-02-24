using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the length of the first side of the triangle:");
        double side1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the length of the second side of the triangle:");
        double side2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the length of the third side of the triangle:");
        double side3 = double.Parse(Console.ReadLine());

        double area = CalculateTriangleArea(side1, side2, side3);

        Console.WriteLine($"The area of the triangle is: {area}");
    }

    static double CalculateTriangleArea(double a, double b, double c)
    {
        double s = (a + b + c) / 2;

        double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

        return area;
    }
} 
