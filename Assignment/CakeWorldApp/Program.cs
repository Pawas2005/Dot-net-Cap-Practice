namespace CakeWorld;

public class Program
{
    public static void Main()
    {
        Cake cake = new Cake();

        Console.WriteLine("Enter the flavour ");
        cake.Flavour = Console.ReadLine();

        Console.WriteLine("Enter the quantity in kg ");
        cake.QuantityInKg = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the price per kg ");
        cake.PricePerKg = int.Parse(Console.ReadLine());

        try
        {
            cake.CakeOrder();
            Console.WriteLine("Cake order was successful");
            Console.WriteLine("Price after discount is " + cake.CalculatePrice());
        }
        catch (Cake.InvalidFlavourException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (Cake.NegativeQuantityInKgException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}