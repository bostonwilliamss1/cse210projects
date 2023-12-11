public class Event
{
    private string _eventTitle;
    private string _description;
    private string _date;
    private string _time;

    public Event(string eventTitle, string description, string date, string time)
    {
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time; 
    }
    public void StandardDetails(Address address)
    {
        Console.WriteLine($"You are invited to {_eventTitle}!");
        Console.WriteLine(_description);
        Console.WriteLine($"It is on {_date} at {_time}.");
        Console.WriteLine("Location: ");
        address.DisplayAddress();

    }
    public void FullDetails()
    {
        Console.WriteLine($"You are invited to {_eventTitle}!");
        Console.WriteLine(_description);
        Console.WriteLine($"It is on {_date} at {_time}.");
    }
    public void ShortDescription()
    {
        Console.WriteLine($"{_eventTitle}!");
        Console.WriteLine($"It is on {_date}.");
    }
}