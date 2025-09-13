using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P41_C__SystemOfADown
{
    internal abstract class Shape
    {
        public abstract double Area();

        public override string ToString()
        {
            return $"Area: {Area()}";
        }
    }

    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return Width * Height;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }

    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }

    class Triangle : Shape
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public Triangle(double b, double height)
        {
            Base = b;
            Height = height;
        }

        public override double Area()
        {
            return 0.5 * Base * Height;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }

    class Trapezoid : Shape
    {
        public double Base1 { get; set; }
        public double Base2 { get; set; }
        public double Height { get; set; }
        public Trapezoid(double base1, double base2, double height)
        {
            Base1 = base1;
            Base2 = base2;
            Height = height;
        }

        public override double Area()
        {
            return 0.5 * (Base1 + Base2) * Height;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
