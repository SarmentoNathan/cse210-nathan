using System.Runtime.CompilerServices;

public class SpecialGuest : Guest
{
    /*Class attributes*/
    private string _function;
    private string _task;

    /*Class constructor*/
    public SpecialGuest(string name, string function) : base(name)
    {
        _function = function;
    }

    /*Class methods*/
    public void DelegateTask()
    {
        
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