using System;

namespace QuickMart;

public class Program
{
    public static void Main()
    {
        int MenuOptions = 0;
        SaleTransaction LastTransaction = null;

        while(MenuOptions != 4)
        {
            Console.WriteLine("================== QuickMart Traders ==================");
            Console.WriteLine("1. Create New Transaction (Enter Purchase & Selling Details)");

            Console.WriteLine("2. View Last Transaction");

            Console.WriteLine("3. Calculate Profit/Loss (Recompute & Print)");

            Console.WriteLine("4. Exit");

            Console.Write("Enter your option: ");
            MenuOptions = int.Parse(Console.ReadLine());

            if(MenuOptions == 1)
            {
                LastTransaction = new SaleTransaction();
                LastTransaction.CreateMethod();
            }
            else if(MenuOptions == 2)
            {
                if(LastTransaction == null)
                {
                    Console.WriteLine("No transaction available. Please create one first.");
                    return;
                }
                else
                {
                    LastTransaction.ViewMethod();
                }
            }
            else if(MenuOptions == 3)
            {
                if(LastTransaction == null)
                {
                    Console.WriteLine("No transaction available. Please create one first.");
                    return;
                }
                else
                {
                    LastTransaction.CalculationMethod();
                }
            }
            else if(MenuOptions == 4)
            {
                Console.WriteLine("Thank You. Application closed normally.");
            }
            else
            {
                Console.WriteLine("Invalid Options, Try again.");
            }
        }
    }
}