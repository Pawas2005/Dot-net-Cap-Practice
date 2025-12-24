using System;

namespace revAndpalind
{
    public class RevAndPalindrome
    {
        public static void Run()
        {
            Console.Write("Enter the number: ");
            int num = int.Parse(Console.ReadLine());

            int n = num;
            int rev = 0;

            while (n != 0)
            {
                int dgt = n % 10;
                rev = dgt + (rev * 10);
                n = n / 10;
            }

            Console.WriteLine($"Reverse of {num} is : " + rev);

            if(num == rev)
            {
                Console.WriteLine($"{num} is Palindrome.");
            }
            else
            {
                Console.WriteLine($"{num} is not a Palindrome.");
            }
        }
    }
}