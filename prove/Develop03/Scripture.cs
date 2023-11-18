using System.Security.Cryptography;

public class Scripture 
{
    private string _reference;
    private List<Word> _words = new List<Word>();
    public Scripture(Reference reference, string text)
    {
        _reference = reference.GetDisplayText();
        string[] wordArray = text.Split(" ");
        foreach(string word in wordArray)
        {
            _words.Add(new Word(word));
        }
    }
     public void HideRandomWords(int numberToHide)
{
    if (numberToHide <= 0 || numberToHide > _words.Count)
    {
        return;
    }
    Random randomGenerator = new Random();
    HashSet<int> selectedIndices = new HashSet<int>();

    while (selectedIndices.Count < numberToHide)
    {
        int r_index = randomGenerator.Next(0, _words.Count);
        if (!selectedIndices.Contains(r_index))
        {
            selectedIndices.Add(r_index);
            _words[r_index].Hide();
        }
    }
}
    public string GetDisplayText()
    {
        string words = string.Join(" ", _words.Select(word => word.GetDisplayText()));
        return $"{_reference} {words}";
    }
    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}