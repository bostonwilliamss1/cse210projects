public class BreakingBad : Goal
{
    public BreakingBad(string name, string description, string points) : base(name, description, points)
    {

    }
    public override void RecordEvent()
    {
        Console.WriteLine($"I am sorry! You lost {GetNegativePoints()} points for: {GetName()}.");
        GoalManager gm = GoalManager.Instance;
    }
    public override bool IsComplete()
    {
        return false;
    }
    public override string GetStringRepresentation()
    {
        return $"Breaking a bad habit, {GetName()}, {GetDescription()}, {GetNegativePoints()}";
    }
}