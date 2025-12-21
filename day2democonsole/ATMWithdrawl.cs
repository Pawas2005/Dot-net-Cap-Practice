using System;

namespace Withdraw
{
    public class ATMWithdraw
    {
        public static void Run()
        {
            bool cardInserted = true;
            int actualPin = 0305;
            double balance = 10000;

            if (cardInserted)
            {
                Console.WriteLine("Atm card is Inserted.");
                Console.Write("Enter the PIN: ");
                int EnteredPin = int.Parse(Console.ReadLine());

                if(EnteredPin == actualPin)
                {
                    Console.WriteLine("Atm Pin is verified.");
                    Console.Write("Enter your withdrawl amount: ");
                    double amount = double.Parse(Console.ReadLine());

                    if(amount <= balance)
                    {
                        balance -= amount;
                        Console.WriteLine("Withdraw Successful");
                        Console.WriteLine("Remaining amount: " + balance);
                    }
                    else
                    {
                        Console.WriteLine("Insufficient balance.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Pin.");
                }
            }
            else
            {
                Console.WriteLine("Please enter your atm card.");
            }
        }
    }
}