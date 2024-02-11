public abstract class Goal
{
    /*Class attributes*/
    private string _shortName;
    private string _description;
    private int _points;

    /*Class Constructor*/
    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    /*Class Methods*/
    
    // Record Event Method - will be shared by other classes
    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        string checkFlag = " ";

        if (IsComplete())
            checkFlag = "X";
        else
            checkFlag = " ";

        string message = $"[{checkFlag}] {_shortName}: ({_description})";

        return message;
    }

    public virtual string GetStringRepresentation()
    {
        return $"{_shortName},{_description},{_points}";
    }

    // EXCEEDING THE REQUIREMENTS - Create a GetName function to help the implementation of Record a Goal behaviour
    public string GetName()
    {
        return _shortName;
    }

    // EXCEEDING THE REQUIREMENTS - Create a GetPoints function to help the implementation of Record a Goal behaviour
    public virtual int GetPoints()
    {
        return _points;
    }
}