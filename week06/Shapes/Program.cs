using System;
using System.Formats.Asn1;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> _shapes = new List<Shape>();
        Square _square = new Square("Red", 2);
        Rectangle _rectangle = new Rectangle("Blue", 2, 3);
        Circle _circle = new Circle("White", 2);

        _shapes.Add(_square);
        _shapes.Add(_rectangle);
        _shapes.Add(_circle);

        foreach (Shape shape in _shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"color: {color}; area: {area}");
        }
    }
}