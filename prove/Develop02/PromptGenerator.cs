public class PromptGenerator
{
    // Adding attributes for this class
    public List<string> _prompts = new List<string>() 
    {
        "What were the highlights of your day, and how did they make you feel?",
        "Did you encounter any challenges or obstacles today? How did you overcome them or learn from them?",
        "Describe a moment of gratitude you experienced today and why it had an impact on you.",
        "What are three things you accomplished today, no matter how small, that you are proud of?",
        "Reflect on a conversation or interaction that stood out to you. What did you learn from it?",
        "How did you prioritize self-care today, and what activities brought you a sense of relaxation or joy?",
        "Identify one thing you would like to improve or work on in yourself. What steps can you take to achieve this?",
        "Share a specific goal you have for the future and outline actionable steps towards its attainment.",
        "Write about a piece of advice or wisdom you received today and how it resonated with you.",
        "Reflect on your emotional state throughout the day. What factors contributed to your mood, and how can you navigate similar situations in the future?"
    };

    // Class constructor
    public PromptGenerator()
    {

    }

    // Class Methods
    public string GetRandomPrompt()
    {
        // Getting the dimension of the list of prompts
        int promptsNumber = _prompts.Count;

        // Determining the prompt to be displayed using Random class
        Random rnd = new Random();
        string chosenPrompt = _prompts[rnd.Next(promptsNumber)];

        // Return value
        return chosenPrompt;
    }
}