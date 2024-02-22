public abstract class Couple
{
    /*Class attributes*/
    private string _name;
    private int _age;
    private string _phone;
    private string _vow;

    /*Class Constructor*/
    public Couple(string name, int age, string phone)
    {
        _name = name;
        _age = age;
        _phone = phone; 
    }

    /*Class methods*/
    public void SetVow(string vow)
    {
        _vow = vow;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetFirstName()
    {
        var names = _name.Split(' ');
        string firstName = names[0];
        
        return firstName;
    }
    
    public int GetAge()
    {
        return _age;
    }

    public string GetVow()
    {
        return _vow;
    }

    public string GetPhone()
    {
        return _phone;
    }

    public abstract void WriteVow();
}