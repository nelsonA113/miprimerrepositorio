using System;
using System.Collections.Generic;

abstract class GeometricFigure
{
    public string Name { get; }
    protected GeometricFigure(string name) => Name = name;
    public abstract double CalculateArea();
    public abstract double CalculatePerimeter();
}

class Circle : GeometricFigure
{
    private double Radius { get; }
    public Circle(string name, double radius) : base(name) => Radius = radius;
    public override double CalculateArea() => Math.PI * Math.Pow(Radius, 2);
    public override double CalculatePerimeter() => 2 * Math.PI * Radius;

}

class Square : GeometricFigure
{
    private double Side { get; }
    public Square(string name, double side) : base(name) => Side = side;
    public override double CalculateArea() => Math.Pow(Side, 2);
    public override double CalculatePerimeter() => 4 * Side;

}

class Rhombus : GeometricFigure
{
    private double Diagonal1 { get; }
    private double Diagonal2 { get; }
    private double Side { get; }
    public Rhombus(string name, double diagonal1, double diagonal2, double side) : base(name)
    {
        Diagonal1 = diagonal1;
        Diagonal2 = diagonal2;
        Side = side;
    }
    public override double CalculateArea() => (Diagonal1 * Diagonal2) / 2;
    public override double CalculatePerimeter() => 4 * Side;
}

class Kite : GeometricFigure
{
    private double Diagonal1 { get; }
    private double Diagonal2 { get; }
    private double Side1 { get; }
    private double Side2 { get; }
    public Kite(string name, double diagonal1, double diagonal2, double side1, double side2) : base(name)
    {
        Diagonal1 = diagonal1;
        Diagonal2 = diagonal2;
        Side1 = side1;
        Side2 = side2;
    }
    public override double CalculateArea() => (Diagonal1 * Diagonal2) / 2;
    public override double CalculatePerimeter() => 2 * (Side1 + Side2);
}

class Rectangle : GeometricFigure
{
    private double Lenght { get; }
    private double Width { get; }
    public Rectangle(string name, double lenght, double width) : base(name)
    {
        Lenght = lenght;
        Width = width;
    }
    public override double CalculateArea() => Lenght * Width;
    public override double CalculatePerimeter() => 2 * (Lenght + Width);
}

class Parallelogram : GeometricFigure
{
    private double Base { get; }
    private double Height { get; }
    private double Side { get; }
    public Parallelogram(string name, double baseLenght, double height, double side) : base(name)
    {
        Base = baseLenght;
        Height = height;
        Side = side;
    }
    public override double CalculateArea() => Base * Height;
    public override double CalculatePerimeter() => 2 * (Base + Side);
}

class Triangle : GeometricFigure
{
    private double Side1 { get; }
    private double Side2 { get; }
    private double Side3 { get; }
    private double Base { get; }
    private double Height { get; }
    public Triangle(string name, double side1, double side2, double side3, double baselenght,  double height) : base(name)
    {
        Side1 = side1;
        Side2 = side2;
        Side3 = side3;
        Base = baselenght;
        Height = height;
    }
    public override double CalculateArea() => (Base * Height) / 2;
    public override double CalculatePerimeter() => Side1 + Side2 + Side3;
}

class Trapeze : GeometricFigure
{
    private double Base1 { get; }
    private double Base2 { get; }
    private double Side1 { get; }
    private double Side2 { get; }
    private double Height { get; }
    public Trapeze(string name, double base1, double base2, double side1, double side2, double height) : base(name)
    {
        Base1 = base1;
        Base2 = base2;
        Side1 = side1;
        Side2 = side2;
        Height = height;
    }
    public override double CalculateArea() => ((Base1 + Base2) * Height) / 2;
    public override double CalculatePerimeter() => Base1 + Base2 + Side1 + Side2;
}







class program
{
    static void Main()
    {
        var circle = new Circle(nameof(Circle), 5);
        var square = new Square(nameof(Square), 10);
        var rhombus = new Rhombus(nameof(Rhombus), 5, 7, 10);
        var kite = new Kite(nameof(Kite), 7, 6, 5, 8);
        var rectangle = new Rectangle(nameof(Rectangle), 4.568, 67.790);
        var parallelogram = new Parallelogram(nameof(Parallelogram), 14.65, 54.67, 23.09);
        var triangle = new Triangle(nameof(Triangle), 45.56, 12.34, 23.09, 15);
        var trapeze = new Trapeze(nameof(Trapeze), 10, 20, 30, 40, 20);
        
        var figures = new List<GeometricFigure>() { circle, square, rhombus, kite, rectangle, parallelogram, triangle, trapeze };
        foreach (var figure in figures)
        {
            Console.WriteLine($"{figure.Name}: Area = {figure.CalculateArea()}, Perimetro = {figure.CalculatePerimeter()}");
        }
    }
}
