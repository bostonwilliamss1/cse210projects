using System.ComponentModel;
class Activity
{
    private string _name;
    private string _description;
    public int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to {_name}");
        Console.WriteLine();
        Console.WriteLine($"{_description}");
        Console.WriteLine();
        Console.WriteLine($"How long, in seconds, would you like for your session?");
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well Done!");
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}");

    }
    public void ShowSpinner(int seconds)
    {
        int totalMilliseconds = seconds * 1000;
        DateTime startTime = DateTime.Now;

        while ((DateTime.Now - startTime).TotalMilliseconds < totalMilliseconds)
        {
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(400);
            Console.Write("\b \b");
            Console.Write("-");
            Console.Write("\b \b");
        }
    }
    public void ShowCountDown()
    {
        for (int i = 5; i > 0; i--)
        {
            Console.Write($"\r{i}");
            Thread.Sleep(1000);
        }
    }
}