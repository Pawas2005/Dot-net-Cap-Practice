using System;

namespace SimpleQues;

public class LargestOfThree
{
    public static void Run()
    {
        Console.Write("Enter num1 : ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter num2 : ");
        int num2 = int.Parse(Console.ReadLine());

        Console.Write("Enter num3 : ");
        int num3 = int.Parse(Console.ReadLine());

        if(num1 > num2 && num1 > num3)
        {
            Console.WriteLine($"num1 : {num1} is the largest");
        }
        else if(num2 > num1 && num2 > num3)
        {
            Console.WriteLine($"num2 : {num2} is the largest");
        }
        else
        {
            Console.WriteLine($"num3 : {num3} is the largest");
        }
    }
}