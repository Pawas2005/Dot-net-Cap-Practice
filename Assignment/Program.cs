//1.Calling Employee.cs file(Assignment 1)
// Employee.Employee.Run();

//2.Calling TicketBookingSystem.cs file(Assignment 2)



//3. Calling Laptop & Desktop price related question(Assignment 3)
using System.Collections;
using System.Net.Http.Headers;
using Computer;
using Desktop;
using Laptop;
public class Programm
{
    public static void Main()
    {
        ComputerClass Computer = new ComputerClass();
        DesktopClass Desktop = new DesktopClass();
        LaptopClass Laptop = new LaptopClass();

        Console.WriteLine("1. Desktop");
        Console.WriteLine("2. Laptop");

        Console.WriteLine("Choose the option ");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("Enter the Processor ");
                Desktop.Processor = Console.ReadLine();

                Console.WriteLine("Enter the ram size ");
                Desktop.RamSize = int.Parse(Console.ReadLine());
                
                Console.WriteLine("Enter the hard disk size ");
                Desktop.HardDiskSize = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the graphic card size ");
                Desktop.GraphicCard = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the monitor size ");
                Desktop.MonitorSize = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the power supply volt ");
                Desktop.PowerSupplyVolt = int.Parse(Console.ReadLine());

                Console.Write("Desktop price is " + Desktop.DesktopPriceCalculation());
                break;

            case 2:
                Console.WriteLine("Enter the Processor ");
                Laptop.Processor = Console.ReadLine();

                Console.WriteLine("Enter the ram size ");
                Laptop.RamSize = int.Parse(Console.ReadLine());
                
                Console.WriteLine("Enter the hard disk size ");
                Laptop.HardDiskSize = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the graphic card size ");
                Laptop.GraphicCard = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the display size ");
                Laptop.DisplaySize = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the battery volt ");
                Laptop.BatteryVolt = int.Parse(Console.ReadLine());

                Console.Write("Laptop price is " + Laptop.LaptopPriceCalculation());
                break;

            default:
                Console.WriteLine("Invalid Options.");
                return;
        }
    }
}
