using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int squared_number = SquareNumber(number);
        DisplayResult(name, squared_number);
    }
    static void DisplayWelcome()
    {
       Console.WriteLine("Welcome to this Course!");
    }
    static string PromptUserName()
    {
        Console.WriteLine("Please Enter Your Name");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.WriteLine("Please Enter Your Favorite Number: ");
        string user = Console.ReadLine();
        int number = int.Parse(user);
        return number;
    }
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }
    static void DisplayResult(string name, int number)
    {
        Console.WriteLine($"{name}, the square of your number is {number}");
    }

}