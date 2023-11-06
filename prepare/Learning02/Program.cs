using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Apple";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2015;
        job1._endYear = 2020;
        

        Job job2 = new Job();
        job2._company = "Microsoft";
        job2._jobTitle = "Programmer";
        job2._startYear = 2020;
        job2._endYear = 2022;   
        

        Resume resume1 = new Resume();
        resume1._name = "Boston Williams";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.DisplayResumeDetails();
    }
}