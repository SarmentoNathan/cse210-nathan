using System.Drawing;
using System.Reflection.Metadata.Ecma335;

public abstract class Shape
{
    /*Class attributes*/
    private string _color = "";

    /*Class Constructor*/
    public Shape(string color)
    {
        SetColor(color);
    }

    /*Class Methods*/
    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    public virtual double GetArea()
    {
        return 0;
    }

}