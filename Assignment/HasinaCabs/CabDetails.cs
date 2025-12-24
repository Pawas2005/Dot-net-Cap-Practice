using System;

namespace HasinaCabs;

public class CabDetails : Cab
{
    public bool ValidateBookingID()
    {
        // Length must be 6
        if(BookingID.Length != 6)
        {
            return false;
        }

        // Must start with "AC@"
        if (!BookingID.StartsWith("AC"))
        {
            return false;
        }

        // Last 3 characters must be digits
        for(int i = 3; i < 6; i++)
        {
            if (!char.IsDigit(BookingID[i]))
            {
                return false;
            }
        }
        
        return true;
    }

     public double CalculateFareAmount()
    {
        double PricePerKm = 0;

        if(CabType == "Hatchback")
        {
            PricePerKm = 10;
        }else if(CabType == "Sedan")
        {
            PricePerKm = 20;
        }
        else if(CabType == "SUV")
        {
            PricePerKm = 30;
        }

        double WaitingCharge = Math.Sqrt(WaitingTime);
        double Fare = Distance * PricePerKm + WaitingCharge;

        // Return fare rounded to 2 decimal places
        return Math.Floor(Fare * 100) / 100;
    }
}
