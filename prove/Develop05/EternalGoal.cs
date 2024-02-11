public class EternalGoal : Goal
{
    /*Class attributes*/
    // No attributes designed for this class

    /*Class constructor*/
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {

    }
    /*Class methods*/
    public override void RecordEvent()
    {
        
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        string message = "Eternal Goal:" + base.GetStringRepresentation();

        return message;
    }
}