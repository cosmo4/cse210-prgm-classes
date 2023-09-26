using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job
        {
            Company = "Microsoft",
            JobTitle = "Software Engineer",
            StartYear = 2011,
            EndYear = 2022
        };
        job1.DisplayJobInfo();
        Job job2 = new Job
        {
            Company = "Apple",
            JobTitle = "Software Engineer",
            StartYear = 2011,
            EndYear = 2022
        };
        job2.DisplayJobInfo();

    }
}