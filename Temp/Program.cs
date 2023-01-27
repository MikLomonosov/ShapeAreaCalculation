using ShapeAreaCalculation.Classes;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
       
        Console.WriteLine(GetShape.Triangle(-0.1, -0.1, -0.1).Area);
    }
}