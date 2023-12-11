public class Outdoors : Event 
{
    private string _weather;
public Outdoors (string weather, string eventTitle, string description, string date, string time) : base(eventTitle, description, date, time)
{
    _weather = weather;
}
public void OutdoorFullDetails(Address address)
{
    StandardDetails(address);
    Console.WriteLine($"You are invited to attend an Outdoor Gathering, " +
                    $"the weather is expected to be {_weather}. So please come prepared");
    Console.WriteLine();
}
public void OutdoorShortDetails()
{
    Console.WriteLine($"You are invited to attend an Outdoor Gathering.");
    ShortDescription();
    Console.WriteLine();
}

}