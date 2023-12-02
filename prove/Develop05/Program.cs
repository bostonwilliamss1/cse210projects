using System;

class Program
{
    static void Main(string[] args)
    {
        int user = 0;
        GoalManager gm = GoalManager.Instance;

        while (user != 6)
        {
            gm.Start();
            Console.WriteLine("Select a choice from the menu: ");
            user = int.Parse(Console.ReadLine());
            
            if (user == 1)
            {
                gm.CreateGoal();  
            }
            else if (user == 2)
            {
                Console.WriteLine("The goals are: ");
                gm.DisplayPlayerInfo();
            }
            else if (user == 3)
            {
                Console.WriteLine("What file would you like to save it to? ");
                Console.Write("> ");
                string filename = Console.ReadLine();
                gm.SaveGoals(filename);
            }
            else if (user == 4)
            {
                Console.WriteLine("What file would you like to load from? ");
                Console.Write("> ");
                string filename = Console.ReadLine();
                gm.LoadGoals(filename);
            }
            else if (user == 5)
            {
                Console.WriteLine("What goal would you like to check off?");
                gm.RecordEvent();

            }
            else if (user == 6)
            {
                Console.WriteLine("Have a nice day!");
            }
        }
    }
}