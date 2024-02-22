public class FoodSupplier : Supplier
{
    /*Class attributes*/
    private List<string> _menu = new List<string>();
    private float _valuePerGuest;
    private float _numberOfGuests;

    /*Class constructor*/
    public FoodSupplier(string name) : base(name)
    {
        _valuePerGuest = 0;
    }

    /*Class Methods*/
    public void SetValue(float value)
    {
        _valuePerGuest = value;
    }

    public void SetNumberOfGuests(int numbOfGuests)
    {
        _numberOfGuests = numbOfGuests;
    }
    public override void CalculateFee()
    {
        SetFee(_valuePerGuest*_numberOfGuests);
    }

    public void AddMenu(string food)
    {
        _menu.Add(food);
    }
    
    public void PrintMenu()
    {
        foreach(string item in _menu)
        {
            Console.WriteLine(item);
        }
    }
}