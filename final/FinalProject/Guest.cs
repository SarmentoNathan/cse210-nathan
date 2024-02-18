public class Guest
{
    /*Class attributes*/
    private string _name;
    private bool _willGo;

    /*Class Constructor*/
    public Guest(string name)
    {
        _name = name;
    } 

    /*Class methods*/
    public void ConfirmPresence()
    {

    }

    public bool GetPresence()
    {
        return _willGo;
    }
}