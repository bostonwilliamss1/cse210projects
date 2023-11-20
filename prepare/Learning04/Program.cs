using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment math = new MathAssignment("Boston Williams", "Math", "7.3", "8-9");
        WritingAssignment write = new WritingAssignment("Boston Williams", "Writing", "Essay Title");
        Console.WriteLine(math.getSummary());
        Console.WriteLine(math.GetHomeworkList());
        Console.WriteLine(write.getSummary());
        Console.WriteLine(write.GetWritingInformation());

    }
}