using System;
using System.Diagnostics;

namespace VowCon
{
    public class VowORCon
    {
        public static void Run()
        {
            Console.Write("Enter any character of your choice: ");
            char ch = char.ToLower(Console.ReadKey().KeyChar);    
            // Console.ReadKey() = Waits for the user to press one key, Ex: A
            // .KeyChar = Takes only the character from the pressed key, Example: A, b, 7, @
            // char.ToLower = Converts the character to lowercase like, 'A' → 'a'

            Console.WriteLine();

            switch (ch)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':                
                    Console.WriteLine("Vowel");
                    break;

                default:
                    Console.WriteLine("Consonant");
                    break;
            }
        }
    }
}