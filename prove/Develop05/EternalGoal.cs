public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string points) : base(name, description, points)
    {

    }
    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulations! You earned {GetPoints()} points for completing {GetName()}.");
        GoalManager gm = GoalManager.Instance;
    }
    
    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"Eternal Goal, {GetName()}, {GetDescription()}, {GetPoints()}";
    }

    }