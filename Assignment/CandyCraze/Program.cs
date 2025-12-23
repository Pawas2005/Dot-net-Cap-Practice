namespace CandyCraze;

public class Program
{
    public static void Main()
    {
        Candy candy = new Candy();

        Console.WriteLine("Enter the flavour ");
        candy.Flavour = Console.ReadLine();

        Console.WriteLine("Enter the Quantity ");
        candy.Quantity = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the price per piece ");
        candy.PricePerPiece = int.Parse(Console.ReadLine());

        if (candy.ValidateCandyFlavour())
        {
            Candy result = CalculateDiscountedPrice(candy);

            Console.Write("Flavour: " + result.Flavour);
            Console.Write("\nQuantity : " + result.Quantity);
            Console.Write("\nPrice Per Piece : " + result.PricePerPiece);
            Console.Write("\nTotal Price: " + result.TotalPrice);
            Console.Write("\nDiscount Price : " + result.Discount);
        }
        else
        {
            Console.WriteLine("Invalid flavour");
        }
    }

    public static Candy CalculateDiscountedPrice(Candy candy)
    {
        double DiscountPer = 0;

        if(candy.Flavour == "Strawberry")
        {
            DiscountPer = 15;
        }
        else if(candy.Flavour == "Lemon")
        {
            DiscountPer = 10;
        }
        else if(candy.Flavour == "Mint")
        {
            DiscountPer = 5;
        }
        
        candy.TotalPrice = candy.Quantity * candy.PricePerPiece;
        candy.Discount = candy.TotalPrice - (candy.TotalPrice * DiscountPer / 100);

        return candy;
    }
}