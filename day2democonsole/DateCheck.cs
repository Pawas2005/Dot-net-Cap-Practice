using System;

namespace DateCheck
{
    public class DateCheck
    {
        public static void Run()
        {
            Console.Write("Enter the day: ");
            int day = int.Parse(Console.ReadLine());

            Console.Write("Enter the month: ");
            int month = int.Parse(Console.ReadLine());

            Console.Write("Enter the Year: ");
            int year = int.Parse(Console.ReadLine());

            bool isValid = true;

            //Checking for month
            if(month < 1 || month > 12)
            {
                isValid = false;
            }
            else
            {
                int daysInMonth; //for checking days in the month
                
                if(month == 2)
                {
                    //Checking For Leap Year
                    if((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
                    {
                        daysInMonth = 29;
                    }
                    else
                    {
                        daysInMonth = 28;
                    }
                }
                else if(month == 4 || month == 6 || month == 9 || month == 11)
                {
                    daysInMonth = 30;
                }
                else
                {
                    daysInMonth = 31;
                }
                if(day < 1 || day > daysInMonth)
                {
                    isValid = false;
                }
            }

            Console.Write(isValid ? "Valid Date" : "Invalid Date");
        }
    }
}