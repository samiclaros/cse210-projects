public class Rectangle : Shape
{
    private double _side;
    private double _large;

    public Rectangle(string color, double side, double large) : base(color)
    {
        _side = side;
        _large = large;
    }

    public override double GetArea()
    {
        return _side * _large;
    }
}