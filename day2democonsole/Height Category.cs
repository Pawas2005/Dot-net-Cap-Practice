using System;

namespace HeightCategory
{
    public class HeightCategory{
        public static void Run()
        {
            Console.Write("Enter your height in cm: ");
            int height;
            while(!int.TryParse(Console.ReadLine(), out height))
            {
                Console.WriteLine("Invalid input, try again!");
            }

            if(height < 150)
            {
                System.Console.WriteLine("Dwarf");
            }
            else if(height >= 150 && height <= 165)
            {
                System.Console.WriteLine("Aage");
            }
            else if(height > 165 && height < 190)
            {
                System.Console.WriteLine("Tall");
            }
            else
            {
                System.Console.WriteLine("Abnormal");
            }
        }
    }
}