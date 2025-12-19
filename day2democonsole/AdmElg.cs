using System;

namespace admsn
{
    public class admsnElg
    {
        public static void Run()
        {
            Console.Write("Enter your Math score: ");
            int math = int.Parse(Console.ReadLine());

            Console.Write("Enter your Physics score: ");
            int phys = int.Parse(Console.ReadLine());

            Console.Write("Enter your Chemistry score: ");
            int chem = int.Parse(Console.ReadLine());

            if((math >= 65) && (phys >= 55) && (chem >= 50) && ((math + phys + chem >= 180) || (math + phys >= 140)))
            {
                System.Console.Write("Student is eligible for admission.");
                System.Console.Write("\nTotal Mark of the Student is = " + (math + phys + chem));
            }
            else
            {
                System.Console.Write("Student is not eligible for admission.");
            }
        }
    }
}