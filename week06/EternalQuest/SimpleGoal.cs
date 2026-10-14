using System.IO; 
public class SimpleGoal
    : Goal
{
    bool _isComplete;
    public SimpleGoal(string name, string description, int points, bool isComplete = false)
        : base(name, description, points)
    {
        _isComplete = isComplete;
    }
    public override int RecordEvent()
    {
        _isComplete = true;
        return _points;
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetStringRepresentation()
    {
        string _StringRepresentation = "SimpleGoal:" + _shortName + ";" + _description + ";" + _points + ";" + _isComplete;
        return _StringRepresentation;
    }
}