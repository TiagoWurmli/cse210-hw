public abstract class Goal
{
    string _shortName;
    string _description;
    int _points;
    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }
    public abstract void RecordEvent();
    public abstract bool  IsComplete();
    public  virtual string GetDetailsString()
    {
        return "";
    }
    public abstract string GetStringRepresentation();
}