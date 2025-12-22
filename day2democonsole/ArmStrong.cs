using System;

namespace ArmStrong
{
    public class ArmStrong
    {
        public static void Run()
        {
            Console.Write("Enter any positive number: ");
            int n = int.Parse(Console.ReadLine());

            if(n < 0)
            {
                Console.WriteLine("Armstrong number is defined only for non-negative numbers.");
                return; //stop execution
            }

            int cnt = 0;
            int num = n;

            while (num != 0)
            {
                int dgt = num % 10;
                num = num / 10;
                cnt++;
            }

            int arm = 0;
            num = n;

            while(num != 0)
            {
                int dgt = num % 10;
                num = num / 10;
                arm += (int)Math.Pow(dgt,cnt); 
            }

            if(arm == n)
            {
                Console.Write($"{n} is an armstrong number.");
            }
            else
            {
                Console.Write($"{n} is not an armstrong number.");
            }
        }
    }
}