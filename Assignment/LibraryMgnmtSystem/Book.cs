namespace Book;

public class Book
{
    //this is example of fields decalaration
    string title;
    string author;
    int numPages;
    DateTime dueDate;
    DateTime returnedDate;
    int daysToRead;
    double dailyLateFeeRate;

    //Parameterized Constructor
    public Book(string title, string author, int numPages, DateTime dueDate, DateTime returnedDate, int daysToRead, double dailyLateFeeRate)
    {
        this.title = title;
        this.author = author;
        this.numPages = numPages;
        this.dueDate = dueDate;
        this.returnedDate = returnedDate;
        this.daysToRead = daysToRead;
        this.dailyLateFeeRate = dailyLateFeeRate;
    }

    public double AveragePagesReadPerDay(int daysToRead)
    {
        return numPages / daysToRead;
    }

    public double CalculateLateFee(double dailyLateFeeRate)
    {
        int NumberOfdayslate = (returnedDate - dueDate).Days;
        return NumberOfdayslate * dailyLateFeeRate;
    }
}