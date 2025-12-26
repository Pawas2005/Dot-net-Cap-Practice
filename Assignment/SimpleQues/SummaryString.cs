using System;

namespace SimpleQues;

public class SummaryString
{
    public static void Run()
    {
        Console.Write("Enter the no. of elements : ");
        int n = int.Parse(Console.ReadLine());

        int[] nums = new int[n];
        Console.WriteLine("Enter the elements : ");
        for(int i = 0; i < n; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }

        int min = nums[0];
        int max = nums[0];
        int sum = 0;

        for(int i = 0; i < n; i++)
        {
            if(nums[i] < min)
            {
                min = nums[i];
            }
            if(nums[i] > max)
            {
                max = nums[i];
            }
            sum += nums[i];
        }

        double average = (double)sum / nums.Length;
        average = Math.Round(average, 2, MidpointRounding.AwayFromZero);

        string summary = $"Min = {min}; Max = {max}; Sum = {sum}; Average = {average}";
        Console.WriteLine(summary);
    }
}