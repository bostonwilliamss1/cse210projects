using System;

class Program
{
    static void Main(string[] args)
    {
        int userInput = -1;
        while (userInput != 4)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("Select a choice from the menu: ");

            string user = Console.ReadLine();
            userInput = int.Parse(user);

            if (userInput == 1)
            {
                int seconds = 0;
                BreathingActivity ba1 = new BreathingActivity("Breathing Activity", "This activity will help you relax "
                + "by walking you through breathing in and out slowly. Clear your mind and focus on breathing", seconds);
                ba1.DisplayStartingMessage();
                ba1._duration = int.Parse(Console.ReadLine());
                ba1.ShowSpinner(2);
                ba1.Run();
                ba1.DisplayEndingMessage();
            }
            else if (userInput == 2)
            {
                ReflectingActivity ra1 = new ReflectingActivity("Reflecting Activity", "This activity "
                + "will help you reflect on times in your life when you have shown strength and resilience. "
                + "This will help you recognize the power you have and how you can use it in other aspects "
                + "of your life", 0);
                ra1.DisplayStartingMessage();
                ra1._duration = int.Parse(Console.ReadLine());
                ra1.ShowSpinner(2);
                ra1.Run();
                ra1.DisplayEndingMessage();
            }
            else if (userInput == 3)
            {
                ListingActivity la1 = new ListingActivity("Listing Activity", "This activity "
                + "will help you reflect on good things in your life by having you list as many things. "
                + "as you can in a certain area. "
                + "of your life", 0);
                la1.DisplayStartingMessage();
                la1._duration = int.Parse(Console.ReadLine());
                la1.ShowSpinner(2);
                la1.Run();
                la1.DisplayEndingMessage();
            }
            else if (userInput == 4)
            {
                Console.WriteLine("Ok, Goodbye");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select a valid option (1-4).");
            }
        }
    }
}
