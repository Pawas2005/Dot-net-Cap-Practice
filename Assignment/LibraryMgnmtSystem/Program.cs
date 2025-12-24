using System;
using System.Globalization;

namespace Book;

public class Program
{
    public static void Main()
    {
        Console.Write("Enter the title: ");
        string title = Console.ReadLine();

        Console.Write("Enter the author: ");
        string author = Console.ReadLine();

        Console.Write("Enter the number of pages: ");
        int numPages = int.Parse(Console.ReadLine());

        // The input date format is MM/dd/yyyy
        Console.Write("Enter the due date (mm/dd/yyyy): ");
        DateTime dueDate = DateTime.ParseExact(Console.ReadLine(), "MM/dd/yyyy", CultureInfo.InvariantCulture);

        Console.Write("Enter the returned date (mm/dd/yyyy): ");
        DateTime returnedDate = DateTime.ParseExact(Console.ReadLine(), "MM/dd/yyyy", CultureInfo.InvariantCulture);

        Console.Write("Enter the days to read: ");
        int daysToRead = int.Parse(Console.ReadLine());

        Console.Write("Enter the daily late feeRate: ");
        double dailyLateFeeRate = double.Parse(Console.ReadLine());

        //Calling Book Parameterized Constructor
        Book bookObj = new Book(title, author, numPages, dueDate, returnedDate, daysToRead,dailyLateFeeRate);

        Console.WriteLine("===========Output==============");
        Console.WriteLine("Average Pages Read Per Day : " + bookObj.AveragePagesReadPerDay(daysToRead));
        Console.WriteLine("Late Fee : " + bookObj.CalculateLateFee(dailyLateFeeRate));
    }
}