using System;

namespace RockPaperScissor
{
    public class RockPaperScissor
    {
        public static void Run()
        {
            Console.Write("Player1 (rock/paper/scissors): ");
            string player1 = Console.ReadLine().ToLower();

            Console.Write("Player2 (rock/paper/scissors): ");
            string player2 = Console.ReadLine().ToLower();

            if(player1 == player2)
            {
                Console.WriteLine("Its, Draw");
            }
            else if(
                (player2 == "rock" && player1 == "scissors") || 
                (player2 == "scissors" && player1 == "paper") || 
                (player2 == "paper" && player1 == "rock"))
            {
                Console.WriteLine("Player2 Wins");
            }
            else if(
                (player1 == "rock" && player2 == "scissors") || 
                (player1 == "scissors" && player2 == "paper") || 
                (player1 == "paper" && player2 == "rock"))
            {
                Console.WriteLine("Player1 Wins");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}