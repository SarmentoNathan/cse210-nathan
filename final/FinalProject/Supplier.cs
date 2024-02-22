public abstract class Supplier
{
    /*Class attributes*/
    private string _name;
    private float _fee;

    /*Class constructor*/
    public Supplier(string name)
    {
        _name = name;
    }

    /*Class methods*/
    public string GetName()
    {
        return _name;
    }

    public void SetFee(float fee)
    {
        _fee = fee;
    }
    public abstract void CalculateFee();

    public float GetFee()
    {
        return _fee;
    }
}