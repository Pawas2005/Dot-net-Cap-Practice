using System;

namespace Quadrant
{
    public class QuadrantFinder
    {
       public static void Run()
        {
            Console.Write("Enter the x-cordinate: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Enter the y-cordinate: ");
            int y = int.Parse(Console.ReadLine());

            if((x > 0) && (y > 0))
            {
                Console.WriteLine($"x: {x} & y: {y} are in First Quadrant");
            }
            else if((x < 0) && (y > 0))
            {
                Console.WriteLine($"x: {x} & y: {y} are in Second Quadrant");
            }
            else if((x < 0) && (y < 0))
            {
                Console.WriteLine($"x: {x} & y: {y} are in Third Quadrant");
            }
            else
            {
                Console.WriteLine($"x: {x} & y: {y} are in Fourth Quadrant");
            }
        } 
    }
}