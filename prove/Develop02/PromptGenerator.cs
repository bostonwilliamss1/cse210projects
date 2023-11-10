using System;
using System.IO;
using System.Collections.Generic;

class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public string GetRandomPrompt()
    {
        string filename = "journal_prompts.txt";
        string[] lines = File.ReadAllLines(filename);
        string prompt;
        foreach (string line in lines){
            string[] parts = line.Split(",");
            prompt = parts[0];
            if (parts.Length > 0){
            _prompts.Add(prompt); 
            }
        }  
        if (_prompts.Count > 0){
            Random randomGenerator = new Random();
            int randomIndex = randomGenerator.Next(0, _prompts.Count);
            return _prompts[randomIndex];
        }
        else
        {
            Console.WriteLine("Error: No valid prompts found in the file.");
            return string.Empty;
        }
    }
}