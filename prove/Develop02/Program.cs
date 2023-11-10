using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        int user = 0;
        string userInput = "";
        string randomPrompt = "";
        string favorite_color = "";
        Dictionary<string, Entry> entryDictionary = new Dictionary<string, Entry>();
        Journal1 journal = new Journal1();
        Entry entry = new Entry();
        Console.WriteLine("Welcome to your journal!");
        Console.WriteLine("");

        while (user != 5)
        {
            Console.WriteLine("Type the number you would like to select: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("> ");
            user = int.Parse(Console.ReadLine());

            if (user == 1)
            {
                PromptGenerator promptGenerator1 = new PromptGenerator();
                randomPrompt = promptGenerator1.GetRandomPrompt();
                Console.WriteLine(randomPrompt);
                Console.Write("> ");
                userInput = Console.ReadLine();
                Console.WriteLine("What is your favorite color?");
                Console.Write("> ");
                favorite_color = Console.ReadLine();
                entry = new Entry
                {
                    _date = dateText,
                    _entryText = userInput,
                    _promptText = randomPrompt,
                    _favoriteColor = favorite_color
                };
                entryDictionary[randomPrompt] = entry;
            }
            else if (user == 2)
            {
               entry.Display();
               journal.DisplayAll();
            }
            else if (user == 3)
            {
               {
            Console.WriteLine("What file would you like to load?");
            Console.Write("> ");
            string filename = Console.ReadLine();
            journal.LoadFromFile(filename);
}
            }
            else if (user == 4)
            {
                Console.WriteLine("What file would you like to save it to?");
                Console.Write("> ");
                string filename = Console.ReadLine();
                journal._entries = entryDictionary.Values.ToList();
                journal.SaveToFile(filename);
            }
            else if (user == 5)
            {
                Console.WriteLine("Have a nice day!");
            }
            else
            {
                Console.WriteLine("Error, try again");
            }
        }
    }
}
