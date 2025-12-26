using System;

namespace SimpleQues;

public class BankAccount
{
    public static void Run()
    {
        Console.Write("Enter the initial balance : ");
        int initialBalance = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of transactions : ");
        int n = int.Parse(Console.ReadLine());

        int[] transactions = new int[n];
        Console.Write("Enter the transactions: ");
        for(int i = 0; i < n; i++)
        {
            transactions[i] = int.Parse(Console.ReadLine());
        }

        for(int i = 0; i < transactions.Length; i++)
        {
            if(transactions[i] >= 0)
            {
                initialBalance += transactions[i]; //Deposit
            }
            else
            {
                if(initialBalance + transactions[i] >= 0)
                {
                    //Withdraw only if enough balance
                    initialBalance += transactions[i];
                }
            }
        }

        Console.WriteLine("Final Balance : " + initialBalance);
    }
}