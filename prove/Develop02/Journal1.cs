using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Journal1
{
    public List<Entry> _entries { get; set; }

   public void DisplayAll()
{
    if (_entries != null)
    {
        foreach (var prompt in _entries)
        {
            if (prompt != null)
            {
                prompt.Display();
                Console.WriteLine();
            }
        }
        }
}
    public void SaveToFile(string filename)
{
    string[] lines = _entries.Select(entry => $"Date: {entry._date} - Prompt({entry._promptText})\n{entry._entryText}\nYour favorite Color is {entry._favoriteColor}").ToArray();
    File.AppendAllLines(filename, lines);
}


    public void LoadFromFile(string filename)
{
    string[] lines = File.ReadAllLines(filename);
    _entries = new List<Entry>();

    foreach (string line in lines)
    {
        string[] parts = line.Split("- Prompt(");

        if (parts.Length >= 2)
        {
            string datePart = parts[0].Trim();
            string promptAndEntryPart = parts[1].TrimEnd(' ', ')');
            string[] promptAndEntry = promptAndEntryPart.Split(") ");

            if (promptAndEntry.Length >= 2)
            {
                Entry entry = new Entry
                {
                    _date = datePart.Substring(datePart.IndexOf(":") + 2).Trim(),
                    _promptText = promptAndEntry[0].Trim(),
                    _entryText = promptAndEntry[1].Trim()
                };

                _entries.Add(entry);
            }
            else
            {
                Console.WriteLine($"Error parsing line: {line}");
            }
        }
        else
        {
            Console.WriteLine($"Error parsing line: {line}");
        }
    }
}
}