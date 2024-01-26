public class Fraction
{
    /*Class attributes*/
    private int _top;
    private int _bottom;

    /*Constructors*/

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    /*Methods*/

    // Getters
    public int GetTop()
    {
        return _top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    // Setters
    public void SetTop(int top)
    {
        _top = top;
        return;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
        return;
    }

    // Methods
    public string GetFractionString()
    {
        return GetTop().ToString() + "/" + GetBottom().ToString();
    }

    public double GetDecimalValue()
    {
        return (double)_top/(double)_bottom;
    }
}