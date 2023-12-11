using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activityList = new List<Activity>();
        Running run = new Running(3, "Dec. 11, 2023", 24);
        Biking bike = new Biking(4, "Nov. 3, 2023", 20);
        Swimming swim = new Swimming(32, "Oct. 19, 2022", 30);

        activityList.Add(run);
        activityList.Add(bike);
        activityList.Add(swim);

        foreach (Activity activity in activityList)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }

    }
}