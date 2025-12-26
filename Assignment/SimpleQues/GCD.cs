using System;
using System.ComponentModel;

namespace SimpleQues;

public class GCD
{
    //Recursion method
    public static int findgcd(int a, int b)
    {
        if(b == 0)
        {
            return a;
        }

        return findgcd(b, a % b);
    }
    public static void Run()
    {
        Console.Write("Enter first non-negative integers: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter second non-negative integers: ");
        int num2 = int.Parse(Console.ReadLine());

        // Euclid's Algorithm
        // int x = num1;
        // int y = num2;

        // while(y != 0)
        // {
        //     int temp = y;
        //     y = x % y;
        //     x = temp;
        // }
        // int gcd = x;

        int gcd = findgcd(num1, num2);
        Console.WriteLine($"G.C.D of {num1} & {num2} is :  {gcd}");
    }
}