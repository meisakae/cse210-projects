using System;
using System.Drawing;
using System.Runtime.ConstrainedExecution;

class Program
{
    static void Main(string[] args)
    {
        List<Shapes> shapes = new List<Shapes>();

        Square s1 = new Square("Red", 4);
        shapes.Add(s1);

        Rectangle s2 = new Rectangle("White", 4, 3);
        shapes.Add(s2);

        Circle s3 = new Circle("blue", 6);
        shapes.Add(s3);

        foreach (Shapes s in shapes)
        {
            string color = s.GetColor();

            double area = s1.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}