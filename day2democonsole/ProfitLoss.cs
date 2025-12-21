using System;

namespace ProfitLoss
{
    public class ProfitLoss
    {
        public static void Run()
        {
            Console.Write("Enter the Cost Price: ");
            double cp = double.Parse(Console.ReadLine());

            Console.Write("Enter the Selling Price: ");
            double sp = double.Parse(Console.ReadLine());

            if(sp > cp)
            {
                double profitPer = ((sp - cp) / cp) * 100;
                Console.Write("Profit Percentage: " + profitPer);
            }
            else if(cp > sp)
            {
                double lossPer = ((cp - sp) / cp) * 100;
                Console.Write("Loss Percentage: " + lossPer);
            }
            else
            {
                Console.Write("Neither profit nor loss.");
            }
        }
    }
}