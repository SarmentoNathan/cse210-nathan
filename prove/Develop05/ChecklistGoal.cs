using System.Data;

public class ChecklistGoal : Goal
{
    /*Class attributes*/
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    /*Class constructor*/
    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    /*Class methods*/
    public override void RecordEvent()
    {
        _amountCompleted ++;
    }

    public override bool IsComplete()
    {
        if(_amountCompleted >= _target)
            return true;
        else
            return false;
    }

    public override int GetPoints()
    {
        if(_amountCompleted == _target)
            return _bonus + base.GetPoints();
        else
            return base.GetPoints();
    }

    public override string GetDetailsString()
    {
        string checklistGoalMessage = base.GetDetailsString() + $" -- Currently Completed: {_amountCompleted}/{_target}";
        return checklistGoalMessage;
    }

    public override string GetStringRepresentation()
    {
        string message = "Checklist Goal:" + base.GetStringRepresentation() + "," + _bonus.ToString() + "," + _target.ToString() + "," + _amountCompleted.ToString();

        return message;
    }
}