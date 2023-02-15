using System;

namespace MethodTask
{
    class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing Shape");
        }
    }

    class Circle : Shape
    {
        public int Radius { get; set; }

        public Circle(int radius)
        {
            Radius = radius;
        }

        public override void Draw()    //The Circle class derives from Shape and overrides the Draw method to output a message that includes the value of the Radius property 
        {
            Console.WriteLine("Drawing Circle with radius " + Radius);
        }

        public void Draw(string color)    //method overloading 
        {
            Console.WriteLine("Drawing Circle with radius " + Radius + " and color " + color);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Shape();
            shape.Draw();

            Circle circle = new Circle(5);
            circle.Draw();
            circle.Draw("red");
        }
    }
}