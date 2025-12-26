using System;

namespace SimpleQues;

public class Sum
{
    public static void Run()
    {
        Console.Write("Enter the no. of elements : ");
        int n = int.Parse(Console.ReadLine());

        object[] Values = new object[n];
        Console.WriteLine("Enter the values (int / string / bool / null / etc.): ");
        for(int i = 0; i < n; i++)
        {
            string inp = Console.ReadLine();

            if(inp == "null")
            {
                Values[i] = null;
            }else if(bool.TryParse(inp, out bool b))
            {
                Values[i] = b;
            }else if(int.TryParse(inp, out int num))
            {
                Values[i] = num;
            }
            else
            {
                Values[i] = inp;
            }
        }

        int sum = 0;
        for(int i = 0; i < Values.Length; i++)
        {
            if(Values[i] is int X) //if it is an int then add it to sum
            {
                sum += X;
            }
        }

        Console.WriteLine("Sum = " + sum);
    }
}