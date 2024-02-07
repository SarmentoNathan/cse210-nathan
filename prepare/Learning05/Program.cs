using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Square("red", 2.5));
        shapes.Add(new Rectangle("blue", 1.2, 3.0));
        shapes.Add(new Circle("green", 1.5));

        foreach(Shape shp in shapes)
        {
            Console.WriteLine($"Shape color: {shp.GetColor()}");
            Console.WriteLine($"Shape area: {shp.GetArea()}");
        } 
    }
}