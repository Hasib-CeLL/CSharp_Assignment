using System;

class Program
{
    static void Main(string[] args)
    {
        double radius = 5.0;
        double area = CalculateCircleArea(radius);
        Console.WriteLine($"The area of the circle with radius {radius} is: {area}");
    }

    static double CalculateCircleArea(double radius)
    {
        double area = 3.1416 * radius * radius;
        return area;
    }
}