using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the radius of the circle: ");
        double radius = Convert.ToDouble(Console.ReadLine());

        double area = CalculateCircleArea(radius);

        Console.WriteLine($"The area of the circle with radius {radius} is: {area}");
    }

    static double CalculateCircleArea(double radius)
    {
        double area = Math.PI * Math.Pow(radius, 2);
        return area;
    }
}
