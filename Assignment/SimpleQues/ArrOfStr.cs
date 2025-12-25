// Given an array of strings, sum only the values that can be parsed as 32-bit integers.
using System;

namespace SimpleQues;

public class ArrOfStr
{
    public static void Run()
    {
        Console.Write("Enter the number of elements: ");
        int n = int.Parse(Console.ReadLine());

        string[] tokens = new string[n]; 

        Console.Write("Enter the elements: ");
        for(int i = 0; i < n; i++)
        {
            tokens[i] = Console.ReadLine();
        }

        int sum = 0;
        for(int i = 0; i < tokens.Length; i++)
        {
            int value;
            if(int.TryParse(tokens[i], out value))
            {
                sum += value;
            }
        }
        Console.WriteLine("Sum = " + sum);
    }
}