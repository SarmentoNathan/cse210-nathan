public class SimpleGoal : Goal
{
    /*Class attributes*/
    private bool _isComplete = false; // False value as default

    /*Class constructor*/
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {

    }

    /*Class methods*/
    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        string message = "Simple Goal:" + base.GetStringRepresentation() + "," + _isComplete.ToString();

        return message;
    }

}