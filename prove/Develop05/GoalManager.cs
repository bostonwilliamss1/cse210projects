using System.Reflection.Metadata;

public class GoalManager
{
    private static GoalManager _instance;
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0; 
    public GoalManager()
    {

    }
    public void Start()
    {
        Console.WriteLine($"You have {_score} points");
        Console.WriteLine("Menu Options: ");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
    }
    public void DisplayPlayerInfo()
    {
        foreach (var goal in _goals)
        {
            if (goal != null)
            {
                Console.WriteLine(goal.GetDetailsString());
                Console.WriteLine();
            }
        }
    }
    public void ListGoalNames()
    {
    foreach (var goal in _goals)
    {
        if (goal != null)
            {
                Console.WriteLine(goal.GetName());
                Console.WriteLine();
            }
    }
    }
    public void ListGoalDetails()
    {
       foreach (var goal in _goals)
    {
        if (goal != null)
            {
                Console.WriteLine(goal.GetDescription());
                Console.WriteLine();
            }
    }
    }
    public void CreateGoal()
    {
        Console.WriteLine("These are the types of goals: ");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("4. Break Bad Habit");
        Console.WriteLine("Which type of goal would you like to create? ");
        int input = int.Parse(Console.ReadLine());
        Goal newgoal = null;
        string name = "";
        string description = "";
        string points = "";
        int bonus = 0;
        int frequency = 0;

        if (input == 1)
                {
                    Console.WriteLine("What is the name of your goal?");
                    name = Console.ReadLine();
                    Console.WriteLine("What is a short description of it? ");
                    description = Console.ReadLine();
                    Console.WriteLine("What is the amount of points associated with this goal? ");
                    points = Console.ReadLine();
                    newgoal = new SimpleGoal(name, description, points);
                    _goals.Add(newgoal);
                }
                // eternal goal
                else if (input == 2)
                {
                    Console.WriteLine("What is the name of your goal?");
                    name = Console.ReadLine();
                    Console.WriteLine("What is a short description of it? ");
                    description = Console.ReadLine();
                    Console.WriteLine("What is the amount of points associated with this goal? ");
                    points = Console.ReadLine();
                    newgoal = new EternalGoal(name, description, points);
                    _goals.Add(newgoal);
                }
                // checklist goal
                else if (input == 3)
                {
                    Console.WriteLine("What is the name of your goal?");
                    name = Console.ReadLine();
                    Console.WriteLine("What is a short description of it? ");
                    description = Console.ReadLine();
                    Console.WriteLine("What is the amount of points associated with this goal? ");
                    points = Console.ReadLine();
                    Console.WriteLine("How many times does this goal need to be accomplished for a bonus");
                    frequency = int.Parse(Console.ReadLine());
                    Console.WriteLine("What is the bonus for accomplishing it that many times? ");
                    bonus = int.Parse(Console.ReadLine());
                    newgoal = new CheckListGoal(name, description, points, frequency, bonus);
                    _goals.Add(newgoal);
                }
                //Breaking a Bad Habit
                else if (input == 4)
                {
                    Console.WriteLine("What is the name of your habit you would like to break");
                    name = Console.ReadLine();
                    Console.WriteLine("What is a short description of it?");
                    description = Console.ReadLine();
                    Console.WriteLine("What is the amount of points you would like to lose if you break this habit?");
                    points = Console.ReadLine();
                    newgoal = new BreakingBad(name, description, points);
                    _goals.Add(newgoal);
                }

    }
    public void RecordEvent()
{
    Console.WriteLine("Choose the goal you accomplished:");

    for (int i = 0; i < _goals.Count; i++)
    {
        Goal goal = _goals[i];
        string completionStatus = goal.IsComplete() ? "X" : " ";
        Console.WriteLine($"{i + 1}. [{completionStatus}] {_goals[i].GetName()}");
    }

    int totalGoals = _goals.Count();
    Console.WriteLine($"Enter a number between 1 and {totalGoals}: ");
    int accomplished = int.Parse(Console.ReadLine());

    if (accomplished >= 1 && accomplished <= totalGoals)
    {
        Goal selectedGoal = _goals[accomplished - 1];
        selectedGoal.RecordEvent();
        UpdateScore(int.Parse(selectedGoal.GetPoints()));
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a valid goal number.");
    }

    }
    public void LoadGoals(string filename)
{
    string[] lines = File.ReadAllLines(filename);

    foreach (string line in lines)
    {
        string[] parts = line.Split(',');

        if (parts.Length >= 3)
        {
            string goaltype = parts[0].Trim();
            string name = parts[1].Trim();
            string description = parts[2].Trim();
            string points = parts[3].Trim();

            if (goaltype == "Simple Goal")
            {
                Goal goal = new SimpleGoal(name, description, points);
                _goals.Add(goal);
            }
            else if (goaltype == "Eternal Goal")
            {
                Goal goal = new EternalGoal(name, description, points);
                _goals.Add(goal);
            }
            else if (goaltype == "Check List Goal" && parts.Length >= 6)
            {
                
                string[] fraction = parts[4].Split("/");
                int target = int.Parse(fraction[1]);
                int bonus = int.Parse(parts[5].Trim());
                Goal goal = new CheckListGoal(name, description, points, target, bonus);
                _goals.Add(goal);
            }
            else if (goaltype == "Breaking a bad habit")
            {
                Goal goal = new BreakingBad(name, description, points);
                _goals.Add(goal);
            }
        }
    }
}
    public void SaveGoals(string filename)
{
    string[] goalLines = _goals.Select(goal => goal.GetStringRepresentation()).ToArray();
    File.WriteAllLines(filename, goalLines);
}

    public void UpdateScore(int points)
    {
        _score += points;
    }
    public static GoalManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new GoalManager();
            }
            return _instance;
        }
    }

    
}