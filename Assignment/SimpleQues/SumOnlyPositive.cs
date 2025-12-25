using System;

namespace SimpleQues;

public class SumOnlyPositive
{
    public static void Run()
    {
        Console.Write("Enter number of elements : ");
        int n = int.Parse(Console.ReadLine());

        int[] nums = new int[n];
        Console.WriteLine("Enter the numbers: ");
        for(int i = 0; i < n; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }

        int sum = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] == 0)
            {
                break;  // stop processing
            }
            else if(nums[i] < 0)
            {
                continue;   //ignore it
            }
            else
            {
                sum += nums[i];
            }
        }
        Console.WriteLine("sum : " + sum); 
    }
}