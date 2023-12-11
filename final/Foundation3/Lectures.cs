public class Lectures : Event
{
    private string _speaker;
    private int _capacity;
public Lectures (string speaker, int capacity, string eventTitle, string description, string date, string time) : base(eventTitle, description, date, time)
{
    _speaker = speaker;
    _capacity = capacity;
}
public void LectureFullDetails(Address address)
{
    StandardDetails(address);
    Console.WriteLine($"You are all invited to attend a lecture. {_speaker} will be speaking, " +
                    $"the seating is limited to {_capacity} people. (First come, first serve)");
    Console.WriteLine();
    
}
public void LectureShortDetails()
{
    Console.WriteLine($"You are invited to attend a Lecture.");
    ShortDescription();
    Console.WriteLine();
}
}