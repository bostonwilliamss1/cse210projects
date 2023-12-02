public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public string _favoriteColor;

    public void Display() 
    {
        Console.WriteLine($"Date: {_date} - Prompt({_promptText})");
        Console.WriteLine($"{_entryText}");
        Console.WriteLine($"Your favorite color is {_favoriteColor}");
    }
}
