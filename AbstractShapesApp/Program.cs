using System;

namespace AbstractShapesApp
{
    abstract class Shape
    {
        public abstract double GetArea();
    }

    class Circle : Shape
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    class Rectangle : Shape
    {
        public double Width { get; }
        public double Height { get; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double GetArea()
        {
            return Width * Height;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the radius of the circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            Shape circle = new Circle(radius);

            Console.Write("Enter the width of the rectangle: ");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the height of the rectangle: ");
            double height = Convert.ToDouble(Console.ReadLine());
            Shape rectangle = new Rectangle(width, height);

            Console.WriteLine($"Circle area: {circle.GetArea():F2}");
            Console.WriteLine($"Rectangle area: {rectangle.GetArea():F2}");
        }
    }
}

