using System;
using System.Globalization;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        // Square areaSquare = new("black", 4);
        // Console.WriteLine(areaSquare.GetColor());
        // Console.WriteLine(areaSquare.GetArea());

        // Rectangle areaRectangle = new("blue", 4, 5);
        // Console.WriteLine(areaRectangle.GetColor());
        // Console.WriteLine(areaRectangle.GetArea());

        // Circle areaCircle =  new("red", 4);
        // Console.WriteLine(areaCircle.GetColor());
        // Console.WriteLine(areaCircle.GetArea());

        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square("black", 4));
        shapes.Add(new Rectangle("blue", 4, 5));
        shapes.Add(new Circle("red", 4));

        foreach (Shape shape in shapes)
        {
            double area = shape.GetArea();
            string color = shape.GetColor();
            Console.WriteLine(area);
            Console.WriteLine(color);
        }
    }
}