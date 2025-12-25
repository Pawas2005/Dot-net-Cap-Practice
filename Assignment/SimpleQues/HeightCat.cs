using System;

namespace SimpleQues;

public class heightCategory
{
    public static void Run()
    {
        Console.Write("Enter the height(in cm) : ");
        int height = int.Parse(Console.ReadLine());

        if(height < 150)
        {
            Console.WriteLine($"{height} is Short height.");
        }
        else if(height >= 150 && height < 180)
        {
            Console.WriteLine($"{height} is  Average height.");
        }
        else
        {
            Console.WriteLine($"{height} is Tall height.");
        }
    }
}