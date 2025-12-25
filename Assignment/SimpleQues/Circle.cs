using System;

namespace SimpleQues;

public class Circle
{
    public static void Run()
    {
        Console.Write("Enter the radius of a circle : ");
        double radius = double.Parse(Console.ReadLine());

        double area = Math.PI * radius * radius;
        Console.Write("Area : " + Math.Floor(area * 100) / 100);
    }
}