using System;

namespace SimpleQues;

public class MultiplicationTable
{
    public static void Run()
    {
        Console.Write("Enter the value : ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter the value upto you have to multiplied : ");
        int upto = int.Parse(Console.ReadLine());

        int[] row = new int[upto];

        for(int i = 1; i <= upto; i++)
        {
            row[i - 1] = n * i;
        }

        Console.Write("Multiplication row: [");
        for(int i = 0; i < row.Length; i++)
        {
            Console.Write(row[i]);
            if(i < row.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.Write("]");
    }
}