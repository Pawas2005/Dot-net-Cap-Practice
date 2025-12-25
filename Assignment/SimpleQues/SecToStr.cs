using System;
using System.Transactions;

namespace SimpleQues;

public class SecToStr
{
    public static void Run()
    {
        Console.Write("Enter the totalSeconds(in int): ");
        int totalSeconds = int.Parse(Console.ReadLine());

        int minutes = totalSeconds / 60;
        int seconds = totalSeconds % 60;

        Console.WriteLine("\"" + minutes + ":" + seconds.ToString("D2") + "\"");
        // \" is used to insert double quotes inside a string
        //"D2" ensures 2-digit formatting
    }
}