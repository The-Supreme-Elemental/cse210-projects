public class Rectangle : Shape
{
    private double _width;
    private double _length;

    public Rectangle(double width, double length, string color) : base(color)
    {
        _length = length;
        _width = width;
    }

    public override double GetArea()
    {
        double area = _length * _width;
        return area;
    }
}