using System;

namespace SimpleQues;

public class FeetToCm
{
    public static void Run()
    {
        Console.Write("Enter the feet : ");
        int feet = int.Parse(Console.ReadLine());

        double cm = feet * 30.48;
        Console.Write($"{feet} Feet is equal to " + cm + " centimeters");
    }
}