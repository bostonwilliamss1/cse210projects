using System;

class Program
{
    static void Main(string[] args)
    {
        Square s1 = new Square("blue", 6);

        Rectangle r1 = new Rectangle(3, 4, "green");

        Circle c1 = new Circle("orange", 5);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(r1);
        shapes.Add(s1);
        shapes.Add(c1);
        
        foreach (Shape shape in shapes)
        {
            double area = shape.GetArea();
            string color = shape.GetColor();
            Console.WriteLine(area);
            Console.WriteLine(color);
        }
        
    }
}