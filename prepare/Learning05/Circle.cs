

public class Circle : Shape
{
    /*Class attributes*/
    private double _radius;

    /*Class Constructor*/
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    /*Class Methods*/
    public override double GetArea()
    {
        return Math.PI*_radius*_radius;
    }
}