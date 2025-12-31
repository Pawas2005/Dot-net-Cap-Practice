using System;
using System.Globalization;

namespace SimpleQues;

public abstract class Employee
{
    //Base Class (Abstract -> for Polymorphism)
    public abstract decimal GetPay();
}

//Hourly Employee
public class HourlyEmployee : Employee
{
    private decimal rate;
    private decimal hours;

    public HourlyEmployee(decimal rate, decimal hours)
    {
        this.rate = rate;
        this.hours = hours;
    }
    public override decimal GetPay()
    {
        return rate * hours;
    }
}

//Salaried Employee
public class SalariedEmployee : Employee
{
    private decimal monthlySalary;

    public SalariedEmployee(decimal monthlySalary)
    {
        this.monthlySalary = monthlySalary;
    }
    public override decimal GetPay()
    {
        return monthlySalary;
    }
}

//Commission Employee
public class CommissionEmployee : Employee
{
    private decimal commission;
    private decimal baseSalary;

    public CommissionEmployee(decimal commission, decimal baseSalary)
    {
        this.commission = commission;
        this.baseSalary = baseSalary;
    }

    public override decimal GetPay()
    {
        return commission + baseSalary;
    }
}

public class TotalPyroll
{
    public static decimal CalculateTotal(string[] employees)
    {
        decimal totalPay = 0;

        foreach(string emp in employees)
        {
            string[] parts = emp.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Employee employee = null;

            switch (parts[0])
            {
                case "H":
                    employee = new HourlyEmployee(
                        decimal.Parse(parts[1], CultureInfo.InvariantCulture),
                        decimal.Parse(parts[2], CultureInfo.InvariantCulture)
                    );
                    break;

                case "S":
                    employee = new SalariedEmployee(
                        decimal.Parse(parts[1], CultureInfo.InvariantCulture)
                    );
                    break;

                case "C":
                    employee = new CommissionEmployee(
                        decimal.Parse(parts[1], CultureInfo.InvariantCulture),
                        decimal.Parse(parts[2], CultureInfo.InvariantCulture)
                    );
                    break;
            }

            if(employee != null)
            {
                totalPay += employee.GetPay(); //Polymorphism
            }
        }
        return Math.Round(totalPay, 2);
    }
}