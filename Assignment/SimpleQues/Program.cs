using System;
using System.Globalization;
using SimpleQues;

//1.Calling area of a circle
// SimpleQues.Circle.Run();

//2.Calling converts feet to centimeters
// SimpleQues.FeetToCm.Run();

//3.calling heightCategory.cs file
// SimpleQues.heightCategory.Run();

//4.Calling largest of three.cs file
// SimpleQues.LargestOfThree.Run();

//5.Calling Convert a number of seconds into a string formatted as m:ss file.
// SimpleQues.SecToStr.Run();

//6.Calling Sum Only +ve Number.cs file
// SimpleQues.SumOnlyPositive.Run();

//7.Calling MultiplicationTable.cs file
// SimpleQues.MultiplicationTable.Run();

//8.Calling ArrOfStr.cs file
// SimpleQues.ArrOfStr.Run();

//9.Calling GCD.cs file
// SimpleQues.GCD.Run();

//10.Calling BankAccount.cs file
// SimpleQues.BankAccount.Run();

//11.Calling Sum.cs file
// SimpleQues.Sum.Run();

//12.Calling SummaryString.cs file
// SimpleQues.SummaryString.Run();

//13.Calling 


//14.Calling totalpayroll.cs file
// class Program
// {
//     static void Main()
//     {
//         Console.Write("Enter number of employees : ");
//         int n = int.Parse(Console.ReadLine());

//         string[] employees = new string[n];

//         Console.WriteLine("\nEnter employee details:");
//         Console.WriteLine("Format:");
//         Console.WriteLine("H rate hours");
//         Console.WriteLine("S monthlySalary");
//         Console.WriteLine("C commission baseSalary\n");

//         for(int i = 0; i < n; i++)
//         {
//             Console.Write($"Employee {i + 1} : ");
//             employees[i] = Console.ReadLine();
//         }

//         decimal totalPay = TotalPyroll.CalculateTotal(employees);
//         Console.WriteLine($"\nTotal Payroll = {totalPay:F2}");
//     }
// }


//15.Calling TotalArea.cs file
// using SimpleQues.Shapes;
// class Program
// {
//     static void Main()
//     {
//         Console.Write("Enter no. of Shapes : ");
//         int n = int.Parse(Console.ReadLine());

//         string[] shapes = new string[n];

//         Console.WriteLine("\nEnter Shape Details : ");
//         Console.WriteLine("Format: ");
//         Console.WriteLine("C r (Circle ---> radius r)");
//         Console.WriteLine("R w h (Rectangle ----> width w, height h)");
//         Console.WriteLine("T b h (Triangle ----> base b, height h)");

//         for(int i = 0; i < n; i++)
//         {
//             Console.Write($"Shape {i + 1} : ");
//             shapes[i] = Console.ReadLine();
//         }

//         double totalArea = TotalAreaCalculate.ComputeArea(shapes);
//         Console.WriteLine($"Total Area = {totalArea:F2}");
//     }
// }


//16.Calling SingleArray.cs file
using SimpleQues.SingleArray;

class Program
{
    public static void Main()
    {
        Console.Write("Enter the size of the first array : ");
        int n = int.Parse(Console.ReadLine());

        int[] a = new int[n];
        Console.WriteLine("Enter elements of the first array : ");
        for(int i = 0; i < n; i++)
        {
            a[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter the size of the second array : ");
        int m = int.Parse(Console.ReadLine());

        int[] b = new int[m];
        Console.WriteLine("Enter elements of the second array : ");
        for(int i = 0; i < m; i++)
        {
            b[i] = int.Parse(Console.ReadLine());
        }

        int[] merged = SingleArray.MergeSortedArrays(a, b);

        Console.WriteLine("\nMerged Sorted array : ");
        Console.WriteLine(string.Join(" ", merged));
    }
}