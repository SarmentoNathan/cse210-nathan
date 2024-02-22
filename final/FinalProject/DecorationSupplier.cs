using System.Threading.Channels;

public class DecorationSupplier : Supplier
{
    /*Class attributes*/
    private List<string> _decorationList = new List<string>();
    private List<string> _colors = new List<string>();
    private float _itemValue;

    /*Class constructor*/
    public DecorationSupplier(string name) : base(name)
    {
        _itemValue = 0;
    }

    /*Class methods*/
    public override void CalculateFee()
    {
        SetFee(_itemValue);
    }

    public void AddItem()
    {
        string item;
        int option;
        bool flag = true;

        while(flag)
        {
            Console.WriteLine("Chose an decoration item for your wedding:\n1-Flowers (R$200)\n2-Candles (R$100)\n3-Table linens (R$100)\n4-String lines (R$50)\n5-Ballons (R$80)\n6-Vases (R$50)\n7-Table centerpieces (R$30)\n8-Chair decoration (R$50)\n9-Quit");
            option = int.Parse(Console.ReadLine());

            switch(option)
            {
                case 1:
                    item = "Flowers";
                    _itemValue += 200;
                    _decorationList.Add(item);
                    break;
                case 2:
                    item = "Candles";
                    _itemValue += 100;
                    _decorationList.Add(item);
                    break;
                case 3:
                    item = "Table linens";
                    _itemValue += 100;
                    _decorationList.Add(item);
                    break;
                case 4:
                    item = "String Lines";
                    _itemValue += 50;
                    _decorationList.Add(item);
                    break;
                case 5:
                    item = "Ballons";
                    _itemValue += 80;
                    _decorationList.Add(item);
                    break;
                case 6:
                    item = "Vases";
                    _itemValue += 50;
                    _decorationList.Add(item);
                    break;
                case 7:
                    item = "Table centerpieces";
                    _itemValue += 30;
                    _decorationList.Add(item);
                    break;
                case 8:
                    item = "Chair decoration";
                    _itemValue += 50;
                    _decorationList.Add(item);
                    break;
                case 9:
                    flag = false;
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }
        
    }

    public void AddColor(string color)
    {
        _colors.Add(color);
    }
    
    public void GetDecorationInfo()
    {
        Console.WriteLine("The colors of the wedding decoration are:");
        foreach(string decorationColor in _colors)
        {
            Console.WriteLine(decorationColor);
        }

        Console.WriteLine("\nThe items of your decoration are:");
        foreach(string decorationItem in _decorationList)
        {
            Console.WriteLine(decorationItem);
        }
    }
}