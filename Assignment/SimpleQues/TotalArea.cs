using System;
using System.Globalization;

namespace SimpleQues.Shapes;

//Interface for Area
public interface IArea
{
    double GetArea();
}

//abstract base class
public abstract class Shape : IArea
{
    public abstract double GetArea();
}

//Inheritance : as Circle is inherting property from Circle
public class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * radius * radius;
    }
}

public class Rectangle : Shape
{
    private double width;
    private double height;

    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public override double GetArea()
    {
        return width * height;
    }
}

public class Triangle : Shape
{
    private double baseLength;
    private double height;

    public Triangle(double baseLength, double height)
    {
        this.baseLength = baseLength;
        this.height = height;
    }

    public override double GetArea()
    {
        return 0.5 * baseLength * height;
    }
}

public class TotalAreaCalculate
{
    public static double ComputeArea(string[] shapes)
    {
        double TotalArea = 0;

        foreach(string s in shapes)
        {
            string[] parts = s.Split(' ', StringSplitOptions.RemoveEmptyEntries); 
            Shape shape = null;

            switch (parts[0])
            {
                case "C":
                    shape = new Circle(
                        double.Parse(parts[1], CultureInfo.InvariantCulture)
                    );
                    break;
                
                case "R":
                    shape = new Rectangle(
                        double.Parse(parts[1], CultureInfo.InvariantCulture),
                        double.Parse(parts[2], CultureInfo.InvariantCulture)
                    );
                    break;

                case "T":
                    shape = new Triangle(
                        double.Parse(parts[1], CultureInfo.InvariantCulture),
                        double.Parse(parts[2], CultureInfo.InvariantCulture)
                    );
                    break;
            }

            if(shape != null)
            {
                TotalArea += shape.GetArea(); //Polymorphism
            }
        }

        return Math.Round(TotalArea, 2, MidpointRounding.AwayFromZero);
    }
}