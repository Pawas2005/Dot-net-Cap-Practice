using System;

namespace bill
{
    public class Ebills
    {
        public static void Run()
        {
            Console.Write("Enter the units: ");
            int units;
            while(!int.TryParse(Console.ReadLine(), out units)){
                Console.WriteLine("Invalid input, try again!");
            }

            double Bill;
            if(units <= 199)
            {
                Bill = units * 1.20;
            }
            else if(units <= 400)
            {
                Bill = units * 1.50;
            }
            else if(units <= 600)
            {
                Bill = units * 1.80;
            }
            else
            {
                Bill = units * 2.00;
            }

            if(Bill > 400)
            {
                Bill = Bill + (Bill * 0.15);
            }

            Console.Write("ELECTRICITY BILL = " + Bill);
        }
    }
}