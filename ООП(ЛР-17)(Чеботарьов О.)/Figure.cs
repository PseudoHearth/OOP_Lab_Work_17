using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП_ЛР_17__Чеботарьов_О._
{
    public abstract class Figure
    {
        public abstract double Area();
        public abstract double Perimeter();
    }

    public class Circle : Figure
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }
        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }

    public class Rectangle : Figure
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }
        public override double Area()
        {
            return Length * Width;
        }

        public override double Perimeter()
        {
            return 2 * (Length + Width);
        }
    }

    public class Trapezium : Figure
    {
        public double TopBase { get; set; }
        public double BottomBase { get; set; }
        public double Height { get; set; }
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }
        public double Side4 { get; set; }

        public Trapezium(double topBase, double bottomBase, double height, double side1, double side2, double side3, double side4)
        {
            TopBase = topBase;
            BottomBase = bottomBase;
            Height = height;
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
            Side4 = side4;
        }

        public override double Area()
        {
            return 0.5 * (TopBase + BottomBase) * Height;
        }

        public override double Perimeter()
        {
            return Side1 + Side2 + Side3 + Side4;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5);
            Rectangle rectangle = new Rectangle(3, 4);
            Trapezium trapezium = new Trapezium(5, 10, 6, 7, 5, 7, 10);

            Console.WriteLine($"Коло з радіусом {circle.Radius}:");
            Console.WriteLine($"Площа кола: {circle.Area()}");
            Console.WriteLine($"Довжина кола: {circle.Perimeter()}");

            Console.WriteLine($"Прямокутник з довжиною {rectangle.Length} та шириною {rectangle.Width}:");
            Console.WriteLine($"Площа: {rectangle.Area()}");
            Console.WriteLine($"Периметр: {rectangle.Perimeter()}");

            Console.WriteLine($"Трапеція з верхньою стороною {trapezium.TopBase}, нижньою {trapezium.BottomBase}, висотою {trapezium.Height}, та сторонами {trapezium.Side1}, {trapezium.Side2}, {trapezium.Side3}, та {trapezium.Side4}:");
            Console.WriteLine($"Area: {trapezium.Area()}");
            Console.WriteLine($"Perimeter: {trapezium.Perimeter()}");

            Console.WriteLine("Введіть що-небудь для завершення програми: ");
            Console.ReadLine();
        }
    }
}
