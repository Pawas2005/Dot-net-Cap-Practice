using System;

namespace largest
{
    public class largest3
    {
        public static void Run()
        {
            Console.Write("Enter 1st number: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter 2nd number: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Enter 3rd number: ");
            int c = int.Parse(Console.ReadLine());

            if(a > b && a > c)
            {
                System.Console.WriteLine($"A: {a} is the largest of three");
            }
            else if(b > a && b > c)
            {
                System.Console.WriteLine($"B: {b} is the largest of three");
            }
            else
            {
                System.Console.WriteLine($"C: {c} is the largest of three");
            }
        }
    }
}