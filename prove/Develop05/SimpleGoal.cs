using System.ComponentModel;

public class SimpleGoal : Goal
{
    private bool _isComplete;
    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {
        
    }
    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulations! You earned {GetPoints()} points for completing {GetName()}.");
        GoalManager gm = GoalManager.Instance;
        _isComplete = true;
    }
    public override bool IsComplete()
{
    return _isComplete;
}
    public override string GetStringRepresentation()
    {
        return $"Simple Goal, {GetName()}, {GetDescription()}, {GetPoints()}";
    }
}