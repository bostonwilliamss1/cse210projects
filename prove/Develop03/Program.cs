using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
    Scripture selectedScripture = null;
    string user = "";
    Console.WriteLine("What Scripture Would you like to memorize?");
    Console.WriteLine("Select 1, 2 or 3");
    string input = Console.ReadLine();
    int number = int.Parse(input);
    if (number == 1)
    {
    Reference r1 = new Reference("John", 15, 2);
    Word w1 = new Word("Every branch in me that beareth not fruit he taketh away: and every branch that beareth " +
                       "fruit, he purgeth it, that it may bring forth more fruit.");
    selectedScripture = new Scripture(r1, "Every branch in me that beareth not fruit he taketh away: and every branch that beareth " +
                       "fruit, he purgeth it, that it may bring forth more fruit.");
    Console.WriteLine(r1.GetDisplayText());
    Console.WriteLine(w1.GetDisplayText());
    }
    else if(number == 2)
    {
    Reference r2 = new Reference("2 Nephi", 2, 25);
    Word w2 = new Word("Adam fell that men might be; and men are, that they might have joy.");
    selectedScripture = new Scripture(r2, "Adam fell that men might be; and men are, that they might have joy.");
    Console.WriteLine(r2.GetDisplayText());
    Console.WriteLine(w2.GetDisplayText());
    }
    else if(number == 3)
    {
    Reference r3 = new Reference("John", 3, 16);
    Word w3 = new Word("For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
    selectedScripture = new Scripture(r3, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
    Console.WriteLine(r3.GetDisplayText());
    Console.WriteLine(w3.GetDisplayText());
    }
    else{
        Console.WriteLine("Invalid input, Try again");
    }
    Console.WriteLine();
    Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
    bool hide = false;
    while (user != "quit" && !hide)
    {
    user = Console.ReadLine();
    Console.Clear();
    if (user.Length == 0)
    {
        selectedScripture.HideRandomWords(3);
        Console.WriteLine(selectedScripture.GetDisplayText());
        hide = selectedScripture.IsCompletelyHidden();
    }
    }
    }
}