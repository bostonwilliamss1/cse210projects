public abstract class Goal
{
    private string _shortName;
    private string _description;
    private string _points;

    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }
    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
    string completionStatus = IsComplete() ? "X" : " ";
    return $"[{completionStatus}] {_shortName} ({_description})";
    }

    public abstract string GetStringRepresentation();

    public string GetName()
    {
        return _shortName;
    }

    public string GetDescription()
    {
        return _description;
    }

    public string GetPoints()
    {
        return _points;
    }
    public int GetNegativePoints()
    {
        int number = int.Parse(_points);
        return -number;
    }
}
