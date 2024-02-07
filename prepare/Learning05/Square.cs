using System.Reflection.Metadata.Ecma335;

public class Square : Shape
{
    /*Class attributes*/
    private double _side;

    /*Class Constructor*/
    public Square(string color, double side) : base(color)
    {
        _side = side;
    }

    /*Class Methods*/
    public override double GetArea()
    {
        return _side*_side;
    }
}