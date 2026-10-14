using System.IO; 
public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;
    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }
    public abstract int RecordEvent();
    public abstract bool  IsComplete();
    public  virtual string GetDetailsString()
    {
        string detailsString = _shortName + " (" + _description + ")";
        return detailsString;
    }
    public abstract string GetStringRepresentation();
    public int GetPoints()
    {
        return _points;
    }
    public string GetName()
    {
        return _shortName;
    }
}