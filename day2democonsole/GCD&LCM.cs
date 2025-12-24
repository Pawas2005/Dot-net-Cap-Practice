using System;

namespace GCDAndLCM
{
    public class GCDAndLCM
    {
        public static void Run()
        {
            Console.Write("Enter the num1: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the num2: ");
            int num2 = int.Parse(Console.ReadLine());

            //GCD - Greatest Common Divisor, is the greatest number that divides both values.
            //LCM - Least Common Multiple, is the smallest number that is divisible by both numbers.  LCM = (num1 × num2) / GCD

            int x = num1;
            int y = num2;

            while(y != 0)
            {
                int temp = y;
                y = x % y;
                x = temp;
            }

            int gcd = x;
            Console.WriteLine($"G.C.D of {num1} & {num2} is : " + gcd);

            int lcm = (num1 * num2) / gcd;
            Console.WriteLine($"L.C.M of {num1} & {num2} is : " + lcm);
        }
    }
}