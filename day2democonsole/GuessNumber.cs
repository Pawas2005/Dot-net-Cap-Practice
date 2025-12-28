using System;

namespace Day2DemoConsole;

public class GuessNumber
{
    public static void Run()
    {
        Console.Write("Enter the Secret Number : ");
        int SecretNumber = int.Parse(Console.ReadLine());

        int GuessNumber;

        do
        {
            Console.Write("Guess the number : ");
            GuessNumber = int.Parse(Console.ReadLine());

            if(GuessNumber > SecretNumber)
            {
                Console.WriteLine("Too high!");
            }else if(GuessNumber < SecretNumber)
            {
                Console.WriteLine("Too Low");
            }
            else
            {
                Console.WriteLine("Correct! You guessed it.");
            }
        }while(GuessNumber != SecretNumber);
    }
}