class ListingActivity : Activity 
{
    private int _count;
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    public ListingActivity(string name, string discription, int duration) : base(name, discription, duration)
    {

    } 
    public void Run()
    {
        Console.WriteLine("Get Ready!");
        ShowSpinner(2);
        Console.WriteLine("List as many responses as you can to the following prompt: ");
        Console.WriteLine("You may begin in: ");
        ShowCountDown();
        Console.WriteLine();
        GetRandomPrompt();
        int totalMilliseconds = _duration * 1000;
        DateTime startTime = DateTime.Now;
        while ((DateTime.Now - startTime).TotalMilliseconds < totalMilliseconds)
        {
            GetListFromUser();
            _count += 1;
        }
        Console.WriteLine($"You listed {_count} items!");
        Console.WriteLine();
    }
    public void GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int num = randomGenerator.Next(0, _prompts.Count);
        if (_prompts.Count > 0)
        {
            Console.WriteLine(_prompts[num]);
        }
        else
        {
            Console.WriteLine("No prompts available.");
        }
    }
    public List<string> GetListFromUser()
    {
       Console.Write("> ");
       string answer = Console.ReadLine();
       List<string> answers = new List<string>();
       answers.Add(answer);
    return answers;
    }
    
}