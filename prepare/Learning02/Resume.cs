using System;
using System.Collections.Generic;

public class Resume
{
    // Properties
    public string Name { get; set; }
    public List<Job> Jobs { get; set;}

    // Constructor
    public Resume()
    {
    }

    // Methods
    public void DisplayResume()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Jobs:");
        foreach (Job job in Jobs)
        {
            job.DisplayJobInfo();
        }
    }

}