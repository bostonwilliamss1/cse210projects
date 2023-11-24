class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
    "Think of a time when you stood up for someone else.",
    "Think of a time when you did something really difficult.",
    "Think of a time when you helped someone in need.",
    "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    public ReflectingActivity(string name, string discription, int duration) : base(name, discription, duration)
    {

    }
    public void Run()
    {
        Console.WriteLine("Get Ready!");
        ShowSpinner(2);
        DisplayPrompt();
        ShowSpinner(2);
        Console.WriteLine("When you have something in mind, press enter to continue: ");
        string user = Console.ReadLine();
        if (user.Length == 0){
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience");
        Console.WriteLine("You may begin in: ");
        ShowCountDown();
        int totalMilliseconds = _duration * 1000;
        DateTime startTime = DateTime.Now;
        while ((DateTime.Now - startTime).TotalMilliseconds < totalMilliseconds)
        {
            DisplayQuestions();
            ShowSpinner(2);
            Console.ReadLine();
        }
        }
    }
    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int num = randomGenerator.Next(0, _prompts.Count);
        if (_prompts.Count > 0)
        {
            return _prompts[num];
        }
        else
        {
            return "No prompts available.";
        }
    }
    public string GetRandomQuestion()
    {
        Random randomGenerator = new Random();
        int num = randomGenerator.Next(0, _questions.Count);
        if (_questions.Count > 0)
        {
            return _questions[num];
        }
        else
        {
            return "No questions available.";
        }
    }
    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
    }
    public void DisplayQuestions()
    {
        Console.Clear();
        Console.Write("> ");
        Console.WriteLine(GetRandomQuestion());
    }
}