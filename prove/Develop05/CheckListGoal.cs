using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class CheckListGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public CheckListGoal(string name, string description, string points, int target, int bonus, int amountCompleted) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }
    public CheckListGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }


    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulations! You earned {GetPoints()} points for completing {GetName()}.");
        _amountCompleted += 1;
        GoalManager gm = GoalManager.Instance;

        if (_amountCompleted == _target)
        {
            Console.WriteLine($"You also get a bonus of {_bonus} points!");
            gm.UpdateScore(_bonus);
        }
    }
    public override bool IsComplete()
    {
    return _amountCompleted >= _target;
    }
    public override string GetDetailsString()
    {
        string name = GetName();
        string description = GetDescription();
        string points = GetPoints();
        string completionStatus = IsComplete() ? "X" : " ";
        return $"[{completionStatus}] {name} ({description}) - Currently Completed {_amountCompleted}/{_target}";
    }
    public override string GetStringRepresentation()
    {
        return $"Check List Goal, {GetName()}, {GetDescription()}, {GetPoints()}, {_amountCompleted}/{_target}, {_bonus} ";
    }
}