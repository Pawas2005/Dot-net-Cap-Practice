using System;

namespace Day2DemoConsole;

public class BinToDec
{
    public static void Run()
    {
        Console.Write("Enter a binary number : ");
        string binary = Console.ReadLine();

        int decVal = 0;
        int power = 1; // 2^0

        for(int i = binary.Length - 1; i >= 0; i--)
        {
            if(binary[i] == '1')
            {
                decVal += power;
            }
            power *= 2;
        }
        Console.WriteLine("Decimal Value = " + decVal);
    }
}