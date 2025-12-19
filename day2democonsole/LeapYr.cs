using System;

namespace Leap
{
    public class LeapYr
    {
        public static void Run()
        {
            Console.Write("Enter an year: ");
            int yr;
            while(!int.TryParse(Console.ReadLine(), out yr))
            {
                Console.WriteLine("Invalid input, Try again!");
            }

            if((yr % 400 == 0) || ((yr % 4 == 0) && !(yr % 100 == 0)))
            {
                System.Console.Write($"{yr} is Leap Year");
            }
            else
            {
                System.Console.Write($"{yr} is not a Leap Year");
            }
        }
    }
}