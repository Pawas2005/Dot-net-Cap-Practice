using System;

namespace PrimeNumber
{
    public class PrimeNumber
    {
        public static void Run()
        {
            Console.Write("Enter the number: ");
            int n = int.Parse(Console.ReadLine());

            bool isPrime = true;

            if(n <= 1)
            {
                isPrime = false;
            }
            else
            {
                for(int i = 2; i * i <= n; i++)
                {
                    if(n % i == 0)
                    {
                        isPrime = false;
                        break; //stop loop immediately if any non prime number found
                    }
                }
            }

            if (isPrime)
            {
                Console.WriteLine($"{n} is a Prime Number.");
            }
            else
            {
                Console.WriteLine($"{n} is not a Prime Number.");
            }
        }
    }
}