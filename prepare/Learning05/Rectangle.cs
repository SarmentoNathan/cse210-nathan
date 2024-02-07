public class Rectangle : Shape
{
    /*Class attributes*/
    private double _side1;
    private double _side2;

    /*Class Constructor*/
    public Rectangle(string color, double side1, double side2) : base(color)
    {
        _side1 = side1;
        _side2 = side2;
    }

    /*Class Methods*/
    public override double GetArea()
    {
        return _side1*_side2;
    }
}