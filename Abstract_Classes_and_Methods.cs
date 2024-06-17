using System;

namespace ShapeArea
{
    // Abstract base class
    abstract class Shape
    {
        // Abstract method
        public abstract double GetArea();
    }

    // Derived class Circle
    class Circle : Shape
    {
        public double Radius { get; set; }

        // Constructor
        public Circle(double radius)
        {
            Radius = radius;
        }

        // Implementing the GetArea method
        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    // Derived class Rectangle
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        // Constructor
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        // Implementing the GetArea method
        public override double GetArea()
        {
            return Width * Height;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of Circle
            Circle circle = new Circle(5.0);
            Console.WriteLine($"The area of the circle is: {circle.GetArea()}");

            // Create an instance of Rectangle
            Rectangle rectangle = new Rectangle(4.0, 6.0);
            Console.WriteLine($"The area of the rectangle is: {rectangle.GetArea()}");

            // Pause the console
            Console.ReadLine();
        }
    }
}

