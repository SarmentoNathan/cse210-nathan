public class Guest
{
    /*Class attributes*/
    private string _name;
    private bool _willGo;
    private string _phone;

    /*Class Constructor*/
    public Guest(string name, string phone)
    {
        _name = name;
        _phone = phone;
    } 

    /*Class methods*/
    public void ConfirmPresence()
    {
        bool flag = true;
        string answer;
        
        while(flag)
        {
            Console.WriteLine("Is this guest coming to the wedding? (Y/N)");
            answer = Console.ReadLine();

            switch(answer.ToLower())
            {
                case "y":
                    _willGo = true;
                    flag = false;
                    break;
                case "n":
                    _willGo = false;
                    flag = false;
                    break;
                default:
                    Console.WriteLine("Invalid option!");
                    break;
            }
        }
        
    }

    public bool GetPresence()
    {
        return _willGo;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetPhone()
    {
        return _phone;
    }
}