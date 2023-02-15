using System;

public abstract class Shape   //an abstract class Shape that defines a method Area() that must be implemented by
                              //any class that derives from it.
{
    public abstract double Area();   

    public virtual void Draw()  //Here Shape class also has a virtual method Draw() that can be overridden by any derived class
    {
        Console.WriteLine("Drawing a shape...");
    }
}

public class Circle : Shape
{
    private double _radius;

    public Circle(double radius)
    {
        _radius = radius;
    }

    public override double Area()     // method overridden 
    {
        return Math.PI * _radius * _radius;
    }

    public override void Draw()      //method overridden 
    {
        Console.WriteLine("Drawing a circle...");
    }
}

public class Square : Shape
{
    private double _sideLength;

    public Square(double sideLength)
    {
        _sideLength = sideLength;
    }

    public override double Area()
    {
        return _sideLength * _sideLength;
    }

    public override void Draw()
    {
        Console.WriteLine("Drawing a square...");
    }
}

public class Program
{
    public static void Main()
    {
        Circle circle = new Circle(5.0);
        Square square = new Square(5.0);

        Console.WriteLine("Area of circle: " + circle.Area());
        Console.WriteLine("Area of square: " + square.Area());

        circle.Draw();
        square.Draw();
    }
}

