public class ReflectingActivity:Activity
{
    /*Class attributes*/
    private List<string> _prompts = new List<string>
    {"Reflect on a recent experience that challenged your beliefs or pushed you out of your comfort zone.",
    "Think about a recent interaction with someone close to you (friend, family member, colleague).",
    "Consider a goal you've been working towards recently, whether personal or professional.",
    "Take a moment to think about something or someone you're grateful for in your life.",
    "Reflect on your current self-care practices and how well they're serving you."};
    private List<string> _questions = new List<string>
    {
        "What was the most significant aspect of this situation for me?",
        "How did I contribute to the outcome, positively or negatively?",
        "What emotions did I experience during this situation, and why?",
        "What were the key lessons or insights I gained from this experience?",
        "How did this situation align with my values, beliefs, or goals?",
        "In what ways did I handle challenges or obstacles, and what could I have done differently?",
        "How did others' perspectives or actions influence the outcome?",
        "What strengths or weaknesses did I demonstrate during this situation?",
        "What would I do differently if faced with a similar situation in the future?",
        "How has this experience impacted my personal growth or development?"
    };

    private string _selectedPrompt;
    private string _selectedQuestion;
    /*Class constructor*/
    public ReflectingActivity()
    {
        SetName("Reflecting Activity");
        SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
    }

    /*Class methods*/
    public void Run()
    {
        DisplayStartingMessage();
        int reflectingTime = GetDuration();
        int intervals = 10;

        Console.Clear();

        Console.WriteLine("Get Ready...");
        ShowSpinner(5);

        Console.WriteLine($"\n\nConsider the following prompt:\n--- {GetRandomPrompt()} ---\nWhen you have something in mind, press enter to continue.");
        Console.ReadKey();

        Console.WriteLine("\n\nNow ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);

        Console.Clear();
        
        while(reflectingTime > 0)
        {
            Console.Write($"> {GetRandomQuestion()}\n");
            ShowSpinner(intervals);
            reflectingTime = reflectingTime - intervals;
        }

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        int promptsQuantity = _prompts.Count;

        Random rnd = new Random();
        string chosenPrompt = _prompts[rnd.Next(promptsQuantity)];

        return chosenPrompt;
    }

    public string GetRandomQuestion()
    {
        int questionsQuantity = _questions.Count;

        Random rnd = new Random();
        string chosenQuestion = _questions[rnd.Next(questionsQuantity)];

        return chosenQuestion;
    }

    public void DisplayPrompt()
    {
        Console.Write(GetRandomPrompt());
    }

    public void DisplayQuestions()
    {
        Console.Write(GetRandomQuestion());
    }
}