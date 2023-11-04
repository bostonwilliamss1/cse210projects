using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int user_input = -1;
        while (user_input != 0){
            Console.Write("Enter a number (0 to quit): ");
            string userResponse = Console.ReadLine();
            user_input = int.Parse(userResponse);
            if (user_input != 0)
            {
                numbers.Add(user_input);
            }
        }
        int sum = 0;
        foreach(int number in numbers){
            sum += number;
        }
        Console.WriteLine($"The sum is {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is {average}");

        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The largest number is {max}");
        
    }
    }