using System;

namespace Quad
{
    public class QuadEqn
    {
        public static void Run()
        {
            Console.Write("The value of a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("The value of b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("The value of c: ");
            double c = double.Parse(Console.ReadLine());

            double D = b * b - 4 * a * c;

            if(D > 0)
            {
                double r1 = (-b + Math.Sqrt(D)) / (2 * a);
                double r2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("Below are the 2 real & distinct roots: ");
                Console.Write("Root 1: " + r1);
                Console.Write("\nRoot 2: " + r2);
            }
            else if(D == 0)
            {
                double r = -b / (2 * a);
                Console.WriteLine("Below are the 1 real & equal root: ");
                Console.Write("Root: " + r);
            }
            else
            {
                Console.WriteLine("Roots are imaginary (no real roots).");
            }
        }
    }
}