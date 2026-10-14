using System.IO; 
public class ChecklistGoal
    : Goal
{
    int _amountCompleted;
    int _target;
    int _bonus;
    public ChecklistGoal(string name, string description, int points, int target, int bonus, int amountCompleted = 0)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }
    public override int RecordEvent()
    {
        _amountCompleted++;
        
        if (IsComplete())
        {
            return _points + _bonus;
        }
        else
        {
            return _points;
        }
    }
    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }
    public override string GetStringRepresentation()
    {
        string _StringRepresentation = "ChecklistGoal:" + _shortName + ";" + _description + ";" + _points + ";" + _bonus + ";" + _target + ";" + _amountCompleted;
        return _StringRepresentation;
    }
    public  override string GetDetailsString()
    {
        string detailsString = "[ ] " + _shortName + " (" + _description + ")" + " -- Currently completed: " + _amountCompleted + "/" + _target;
        return detailsString;
    }
}