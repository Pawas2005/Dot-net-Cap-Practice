using System;

namespace Grade
{
    public class GradeDesc
    {
        public static void Run()
        {
            Console.Write("Enter any characters between these E, V, G, A, F: ");
            char ch = Console.ReadKey().KeyChar;
            Console.WriteLine();

            switch (ch)
            {
                case 'A':
                    Console.WriteLine("Average");
                    break;
                case 'E':
                    Console.WriteLine("Excellent");
                    break;
                case 'F':
                    Console.WriteLine("Fail");
                    break;
                case 'G':
                    Console.WriteLine("Good");
                    break;
                case 'V':
                    Console.WriteLine("Very Good");
                    break;   

                default:
                    Console.WriteLine("None of these, Please select among 5 options.");
                    break;
            }
        }
    }
}