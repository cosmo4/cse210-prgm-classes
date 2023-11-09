using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new();

        Rectangle rectangle = new("Green", 5.6, 5.8);
        shapes.Add(rectangle);

        Square square = new("Purple", 2.5);
        shapes.Add(square);

        Circle circle = new("Red", 4);
        shapes.Add(circle);

        foreach(Shape shape in shapes)
        {
            string color = shape.GetColor();

            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape's area is {area} ");
        }

    }
}