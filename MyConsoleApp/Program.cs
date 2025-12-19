using System;

// class Program

// {
//     static void Main()
//     {
//         Console.Write("Enter any odd number: ");
//         int num = int.Parse(Console.ReadLine());

//         if(num == 2)
//         {
//             Console.WriteLine("2 is a rime number");
//         } 
//         else if(num <= 1 || num % 2 == 0)
//         {
//             Console.WriteLine($"{num} is not a prime number");
//         }
//         else
//         {
//             bool isPrime = true;

//             for(int i = 3; i <= Math.Sqrt(num); i += 2)
//             {
//                 if(num % i == 0)
//                 {
//                     isPrime = false;
//                     break;
//                 }
//             }

//             if(isPrime)
//             {
//                 Console.WriteLine($"{num} is a prime number");
//             }
//             else
//             {
//                 Console.WriteLine($"{num} is not a prime number");
//             }
//         }
//     }
// }


// class Program
// {
//     static void Main()
//     {
//         Console.Write("Enter the age: ");
//         string? input = Console.ReadLine();

//         if(int.TryParse(input, out int age))
//         {
//             bool isAdult = age >= 18;
//             Console.WriteLine("Adult?: " + isAdult);
//         }
//         else
//         {
//             Console.WriteLine("Invalid input. Please enter a valid number for age.");
//         }
//     }
// }


// class Program
// {
//     static void Main()
//     {
//         Console.Write("Enter the feet : ");
//         string? inp = Console.ReadLine();

//         if(double.TryParse(inp, out double feet))
//         {
//             double cm = feet * 30.48;
//             Console.WriteLine($"{feet} feets is equal to {cm} centimeters.");
//         }
//         else
//         {
//             Console.WriteLine("Invalid input. Please enter a valid feets.");
//         }
//     }
// }



