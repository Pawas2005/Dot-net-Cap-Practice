using System;

namespace Fibonacci
{
    public class FibonacciSeries
    {
        public static void Run()
        {
            Console.Write("Enter the value of n: ");
            int n = int.Parse(Console.ReadLine());

            if(n <= 0)
            {
                Console.WriteLine("Enter the positive number.");
            }

            int a = 0, b = 1;

            Console.Write($"Fibonacci Series upto {n}: ");
            for(int i = 1; i <= n; i++)
            {
                Console.Write(a + " ");
                int next = a + b;
                a = b;
                b = next;
            }
        }
    }
}