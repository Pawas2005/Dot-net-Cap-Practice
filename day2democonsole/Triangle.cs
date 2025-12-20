using System;

namespace Triangle
{
    public class TriangleType
    {
        public static void Run()
        {
            Console.Write("Enter the first side: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter the second side: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Enter the third side: ");
            int c = int.Parse(Console.ReadLine());

            if((a == b) && (b == c) && (a == c))
            {
                Console.Write($"{a}, {b} & {c} is Equilateral Triangle as all 3 sides are equal.");
            }
            else if((a == b) || (a == c) || (b == c))
            {
                Console.Write($"{a}, {b} & {c} is Isoscles Triangle as its 2 sides are equal.");
            }
            else
            {
                Console.Write($"{a}, {b} & {c} is Scalene Triangle as no sides are equal.");
            }
        }
    }
}
