public class Circle : Shapes
{
    private double _redius;

    public Circle(string color, double radius) : base(color)
    {
        _redius = radius;
    }

    public override double GetArea()
    {
        return _redius * _redius * Math.PI;
    }
}

