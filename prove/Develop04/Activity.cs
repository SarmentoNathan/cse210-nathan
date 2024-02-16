public class Activity
{
    /*Class Attributes*/
    private string _name = "";
    private string _description = "";
    private int _duration = 0;

    /*Class Constructor*/
    public Activity()
    {

    }

    /*Class Methods*/
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to {_name}");
        Console.WriteLine($"{_description}\n");

        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well Done!");
        ShowSpinner(3);
        Console.WriteLine($"You have completed another {_duration} seconds of {_name}");
        ShowSpinner(5);
    }

    public void ShowSpinner(int seconds)
    {
        int times = seconds;
        List<string> animationCharacters = new List<string>{"|","/","-","\\"};

        for(int i = 0; i < times; i++)
        foreach(string character in animationCharacters)
        {
            Console.Write(character);
            Thread.Sleep(250);
            Console.Write("\b \b");
        }
    }

    public void ShowCountDown(int seconds)
    {
        int times = seconds;
        for(int i = 0; i< times; i++)
        {
            Console.Write(seconds);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            seconds --;
        }
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public int GetDuration()
    {
        return _duration;
    }
}