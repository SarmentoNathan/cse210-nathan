public class BreathingActivity:Activity
{
    /*Class attributes*/
    // No attributes

    /*Class constructor*/
    public BreathingActivity()
    {
        SetName("Breathing Activity");
        SetDescription("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind And focus on your breathing.");
    }

    /*Class methods*/
    public void Run()
    {
        DisplayStartingMessage();

        int breathingTime = GetDuration();
        int intervals = 5;
        bool breathFlag = true;

        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowSpinner(5);

        while(breathingTime > 0)
        {
            if(breathFlag)
            {
                Console.Write("\n\nBreath in...");
                ShowCountDown(intervals);
                breathingTime = breathingTime - intervals;
            }

            else
            {
                Console.Write("\n\nBreath out...");
                ShowCountDown(intervals);
                breathingTime = breathingTime - intervals;
            }
            
            breathFlag = !breathFlag;
        }
    }
}