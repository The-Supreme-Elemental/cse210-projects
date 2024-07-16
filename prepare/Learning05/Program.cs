using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Rectangle(5, 10, "purple"));
        shapes.Add(new Circle(5, "pink"));
        shapes.Add(new Square("red", 3));
        foreach (Shape shape in shapes)
        {
            double area = shape.GetArea();
            string color = shape.GetColor();
            Console.WriteLine($"The area for this shape is {area}, and this shape is {color}. ");
        }






    }
}