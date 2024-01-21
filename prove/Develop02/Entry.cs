public class Entry
{
    // Adding Attributes of this class
    public string _date;
    public string _promptText;
    public string _entryText;

    // Class Constructor
    public Entry()
    {

    }

    // Class Methods

    // Update Prompt Method - Uses the PromptGenerator class do update the current prompt to be shown
    public void UpdatePrompt()
    {
        PromptGenerator questions = new PromptGenerator();
        _promptText = questions.GetRandomPrompt();

        return;
    }

    // UpdateDate Method - Uses the DateTime class to update the current date to be shown
    public void UpdateDate()
    {
        DateTime theCurrentTime = DateTime.Now;
        _date = theCurrentTime.ToShortDateString();

        return;
    }

    // UpdateTextEntry Method - Asks the user to write something based on _promptText
    public void UpdateTextEntry ()
    {
        Console.WriteLine(_promptText);
        _entryText = Console.ReadLine();
    }

    // Display Method - Displays the information saved on the Entry class attributes
    public void Display()
    {
        Console.WriteLine($"{_date} - {_promptText}");
        Console.WriteLine(_entryText);
    }
}