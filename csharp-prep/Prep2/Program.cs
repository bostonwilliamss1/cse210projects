using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string input = Console.ReadLine();
        int grade_perc = int.Parse(input);

        string letter = "";

        if (grade_perc >= 90)
         {
            letter = "A";
        }
        else if (grade_perc >= 80 && grade_perc < 90)
        {
            letter = "B";
        }
        else if (grade_perc < 80 && grade_perc >= 70)
        {
            letter = "C";
        }
        else if (grade_perc < 70 && grade_perc >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");

        if (grade_perc >= 70)
        {
            Console.WriteLine("You passed");
        }
        else
        {
            Console.WriteLine("You did not pass!");
        }

    }
}