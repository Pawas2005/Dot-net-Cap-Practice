using System;
using System.Security.Cryptography;

namespace BookingSystem;

public class Program
{
    public static void Main()
    {
        //Step1: Passenger Input
        Console.Write("Enter the Passenger ID: ");
        int passID = int.Parse(Console.ReadLine());

        Console.Write("Enter the Name: ");
        string passName = Console.ReadLine();

        Console.Write("Enter the Age: ");
        int age = int.Parse(Console.ReadLine());

        // Step 2: Age & Eligibility Validation
        if(age < 5)
        {
            Console.WriteLine("Print Free Ticket - No Booking Required");
            return;
        }
        else if(age > 80)
        {
            Console.WriteLine("Medical Clearance Required.");
            return;
        }
        else
        {
            // Step 3A: Travel Type
            Console.WriteLine("Select Travel Type: ");
            Console.WriteLine("1-Bus");
            Console.WriteLine("2-Train");
            Console.WriteLine("3-Flight");
            int choice = int.Parse(Console.ReadLine());

            Console.Write("Enter Base Fare: ");
            double baseFare = double.Parse(Console.ReadLine());

            string Traveltype; //for bus, train, flight
            double multipier = 0; 
            int travelClassChoice;
            string travelClassName = ""; //for seat

            // Step 3b: Class Selection
            switch (choice)
            {
                case 1:
                    Traveltype = "Bus";
                    Console.WriteLine("1-Sleeper");
                    Console.WriteLine("2-Seater");
                    travelClassChoice = int.Parse(Console.ReadLine());

                    switch (travelClassChoice)
                    {
                        case 1:
                            travelClassName = "Sleeper";
                            multipier = 1.2;
                            break;
                        case 2:
                            travelClassName = "Seater";
                            multipier = 1.0;
                            break;
                        default:
                            Console.WriteLine("Only 2 types of seat available.");
                            return;
                    }
                    break;

                case 2:
                    Traveltype = "Train";
                    Console.WriteLine("1-General");
                    Console.WriteLine("2-Sleeper");
                    Console.WriteLine("3-AC");
                    travelClassChoice = int.Parse(Console.ReadLine());

                    switch (travelClassChoice)
                    {
                        case 1:
                            travelClassName = "General";
                            multipier = 1.0;
                            break;
                        case 2:
                            travelClassName = "Sleeper";
                            multipier = 1.3;
                            break;
                        case 3:
                            travelClassName = "AC";
                            multipier = 1.6;
                            break;
                        default:
                            Console.WriteLine("Only 3 types of seat available.");
                            return;
                    }
                    break;

                case 3:
                    Traveltype = "Flight";
                    Console.WriteLine("1-Economy");
                    Console.WriteLine("2-Business");
                    travelClassChoice = int.Parse(Console.ReadLine());

                    switch (travelClassChoice)
                    {
                        case 1:
                            travelClassName = "Economy";
                            multipier = 2.5;
                            break;
                        case 2:
                            travelClassName = "Business";
                            multipier = 3.5;
                            break;
                        default:
                            Console.WriteLine("Only 2 types of seat available.");
                            return;
                    }
                    break;

                default:
                    Console.WriteLine("Invalid options");
                    return;
            }

            double FareAfterClass = baseFare * multipier;
            // Step 5: Discount Calculation 
            double discount = 0;
            
            Console.Write("Is Government Employee (true/false): ");
            bool isGovtEmployee = bool.Parse(Console.ReadLine());

            if(age >= 60)
            {
                discount = 30;
            }
            else if(isGovtEmployee == true)
            {
                discount = 15;
            }
            else if(age >= 5 && age <= 12)
            {
                discount = 50;
            }
            else
            {
                discount = 0;
            }

            double discountAmount = FareAfterClass * discount / 100;
            double FinalFare = FareAfterClass - discountAmount;
            string BookingStatus;

            // Step 6: Booking Status 
            if(FinalFare >= 10000)
            {
                if(Traveltype == "Flight")
                {
                    BookingStatus = "Confirmed";
                }
                else
                {
                    BookingStatus = "Waiting List";
                }
            }
            else
            {
                BookingStatus = "Confirmed";
            }

             // Step 7: Ticket Summary
            Console.WriteLine("\n-------- Ticket Summary --------");
            Console.WriteLine("Passenger ID: " + passID);
            Console.WriteLine("Passenger Name: " + passName);
            Console.WriteLine("Travel Type: " + Traveltype);
            Console.WriteLine("Class: " + travelClassName);
            Console.WriteLine("Base Fare: " + baseFare);
            Console.WriteLine("Final Fare: " + FinalFare);
            Console.WriteLine("Discount Applied: " + discount + "%");
            Console.WriteLine("Booking Status: " + BookingStatus);
        }
    }
}