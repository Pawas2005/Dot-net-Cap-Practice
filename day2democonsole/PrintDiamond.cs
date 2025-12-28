using System;

namespace Day2DemoConsole;

public class PrintDiamond
{
    public static void Run()
    {
        Console.Write("Enter an odd number of rows : ");
        int rows = int.Parse(Console.ReadLine());

        int mid = rows / 2;

        //for upper half of diamond
        for(int i = 0; i <= mid; i++)
        {
            //for printing spaces
            for(int s = 0; s <= mid - i; s++)
            {
                Console.Write(" ");
            }
            //for printing stars
            for(int j = 0; j < (2 * i + 1); j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        //for lower half of diamond
        for(int i = mid - 1; i >= 0; i--)
        {
            //for printing spaces
            for(int s = 0; s <= mid - i; s++)
            {
                Console.Write(" ");
            }
            //for printing stars
            for(int j = 0; j < (2 * i + 1); j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}