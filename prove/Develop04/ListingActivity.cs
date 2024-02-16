public class ListingActivity:Activity
{
    /*Class attributes*/
    private int _count;
    private List<string> _prompts = new List<string>
    {
        "When have you felt the Holy Ghost this month?",
        "What have you learned today?",
        "What do you want to do tomorrow?",
        "What are your favorite scriptures?",
        "How did you take care of yourself recently?",
    };

    /*Class constructor*/
    public ListingActivity()
    {
        SetName("Listing Activity");
        SetDescription("This activity will help you reflect on good things in your life by having you list as many things as you can in a certain area.");
    }

    /*Class methods*/
    public void Run()
    {
        DisplayStartingMessage();
        Console.Clear();

        Console.WriteLine("Get Ready...");
        ShowSpinner(5);

        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.Write("You may begin in: ");
        ShowCountDown(5);

        Console.WriteLine("\n");
        List<string> answersList = GetListFromUser();
        _count = answersList.Count();

        Console.WriteLine($"\nYou listed {_count} items!\n");
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        int promptsQuantity = _prompts.Count;

        Random rnd = new Random();
        string chosenPrompt = _prompts[rnd.Next(promptsQuantity)];

        return chosenPrompt;
    }

    public List<string> GetListFromUser()
    {
        List<string> answersList = new List<string>();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetDuration());

        DateTime currentTime = DateTime.Now;

        while(currentTime < futureTime)
        {
            Console.Write("> ");
            string answer = Console.ReadLine();
            answersList.Add(answer);
            Console.WriteLine();
            currentTime = DateTime.Now;
        }

        return answersList;
    }
}