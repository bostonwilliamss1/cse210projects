using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magic_number = randomGenerator.Next(1, 100);
        
        int guess = -1;

        while (!(magic_number == guess))
        {
            Console.WriteLine("What is your guess: ");
            string user = Console.ReadLine();
            guess = int.Parse(user);

             if (guess > magic_number)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magic_number)
            {
                Console.WriteLine("Higher");
            }
            else if (guess == magic_number)
            {
                Console.WriteLine("You've Guessed It!!");
            }
            
        }
       
    }
}