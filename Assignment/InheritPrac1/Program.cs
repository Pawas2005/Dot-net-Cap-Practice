// Calling Laptop & Desktop price related question to Inheritance(Assignment 3)
using System;
using Computer;
using Desktop;
using Laptop;

public class Program
{
    public static void Main()
    {
        DesktopClass Desktop = new DesktopClass();
        LaptopClass Laptop = new LaptopClass();
        // ComputerClass computer = new ComputerClass();

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

                Console.WriteLine("Desktop price is " + Desktop.DesktopPriceCalculation());
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

                Console.WriteLine("Laptop price is " + Laptop.LaptopPriceCalculation());
                break;

            default:
                Console.WriteLine("Invalid Option.");
                break;
        }
    }
}
