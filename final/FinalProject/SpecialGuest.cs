using System.Runtime.CompilerServices;

public class SpecialGuest : Guest
{
    /*Class attributes*/
    private string _function;
    private string _task;

    /*Class constructor*/
    public SpecialGuest(string name, string phone, string function) : base(name, phone)
    {
        _function = function;
        _task = "";
    }

    /*Class methods*/
    public void DelegateTask()
    {
        Console.WriteLine("Delegate a special task for this guest.");
        _task = Console.ReadLine();
    }

    public string GetFunction()
    {
        return _function;
    }

    public string GetTask()
    {
        return _task;
    }
}