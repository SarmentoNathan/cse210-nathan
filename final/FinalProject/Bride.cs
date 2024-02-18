public class Bride
{
    /*Class attributes*/
    private string _name;
    private int _age;
    private string _vow;

    /*Class Constructor*/
    public Bride(string name, int age)
    {
        _name = name;
        _age = age;
    }

    /*Class methods*/
    public void SetVow()
    {

    }

    public string GetName()
    {
        return _name;
    }

    public int GetAge()
    {
        return _age;
    }

    public string GetVow()
    {
        return _vow;
    }
}