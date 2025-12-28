using System;
using System.Numerics;

namespace Day2DemoConsole;

public class FactorialNumber
{
    public static void Run()
    {
        Console.Write("Enter a number : ");
        int n = int.Parse(Console.ReadLine());

        BigInteger Fact = 1;

        for(int i = 1; i <= n; i++)
        {
            Fact *= i;
        }

        Console.WriteLine($"Factorial Number of {n} : " + Fact);
    }
}