using System;

namespace Calculator
{
    public class Calculator
    {
        public static void Run()
        {
            Console.Write("Enter any operator (+,-,*,/): ");
            char op = Console.ReadKey().KeyChar;
            Console.WriteLine();

            Console.Write("Enter first number: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            double num2 = double.Parse(Console.ReadLine());

            switch (op)
            {
                case '+':
                    Console.Write("Result: " + (num1 + num2));
                    break;
                case '-':
                    Console.Write("Result: " + (num1 - num2));
                    break;
                case '*':
                    Console.Write("Result: " + (num1 * num2));
                    break;
                case '/':
                    if(num2 != 0)
                    {
                        Console.Write("Result: " + (num1 / num2));
                    }
                    else
                    {
                        Console.WriteLine("Division by zero is not allowed.");
                    }
                    break;

                default:
                    Console.Write("Invalid Operator.");
                    break;
            }
        }
    }
}