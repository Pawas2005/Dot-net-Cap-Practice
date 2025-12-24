namespace HasinaCabs;

public class Program
{
    public static void Main()
    {
        CabDetails cab = new CabDetails();

        Console.Write("Enter the booking id : ");
        cab.BookingID = Console.ReadLine();

        if (cab.ValidateBookingID())
        {
            Console.Write("Enter the cab type : ");
            cab.CabType = Console.ReadLine();

            Console.Write("Enter the distance in km : ");
            cab.Distance = double.Parse(Console.ReadLine());

            Console.Write("Enter the waiting time in minutes: ");
            cab.WaitingTime = int.Parse(Console.ReadLine());

            Console.Write("The fare amount is : " + cab.CalculateFareAmount());
        }
        else
        {
            Console.WriteLine("Invalid booking id.");
        }
    }
}