public class DecorationSupplier : Supplier
{
    /*Class attributes*/
    private List<string> _decorationList = new List<string>();
    private List<string> _colors = new List<string>();

    /*Class constructor*/
    public DecorationSupplier(string name) : base(name)
    {

    }

    /*Class methods*/
    public override float CalculateFee()
    {
        return 1000;
    }

    public void AddItem(string item)
    {

    }

    public void AddColor(string item)
    {

    }
    
    public string GetDecorationInfo()
    {
        return "info";
    }
}