using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job
        {
            Company = "Microsoft",
            JobTitle = "Software Engineer",
            StartYear = 2011,
            EndYear = 2019
        };

        Job job2 = new Job
        {
            Company = "Apple",
            JobTitle = "Senior Software Engineer",
            StartYear = 2019,
            EndYear = 2022
        };

        Resume resume1 = new Resume
        {
            Name = "Lucas Finch",
            Jobs = new List<Job> { job1, job2 }
        };

        resume1.DisplayResume();
}
}