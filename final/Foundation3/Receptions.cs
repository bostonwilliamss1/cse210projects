using System.ComponentModel.DataAnnotations;

public class Receptions : Event
{
    private string _email;
public Receptions (string email, string eventTitle, string description, string date, string time) : base(eventTitle, description, date, time)
{
    _email = email;
}
public void ReceptionFullDetails(Address address)
{
    StandardDetails(address);
    Console.WriteLine($"You are invited to attend a Reception. " + $"Please email {_email} to RSVP");
    Console.WriteLine();
}
public void ReceptionShortDetails()
{
    Console.WriteLine($"You are invited to attend a Reception!");
    ShortDescription();
    Console.WriteLine();
}
}