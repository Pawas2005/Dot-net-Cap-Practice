using System;

namespace Day2DemoConsole;

public class PascalTriangle
{
    public static void Run()
    {
        Console.Write("Enter the number of rows : ");
        int n = int.Parse(Console.ReadLine());

        int[,] triangle = new int[n, n];        

        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j <= i; j++)
            {
                if(j == 0 || j == i)
                {
                    triangle[i, j] = 1;
                }
                else
                {
                    triangle[i, j] = triangle[i - 1 , j - 1] + triangle[i - 1 , j];
                }
                Console.Write(triangle[i , j] + " ");
            }
            Console.WriteLine();
        }
    }
}