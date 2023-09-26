public class Resume
{
    // Properties
    public string Name;
    public List<Job> Job = new List<Job>();

    // Constructor
    public Resume()
    {
    }

    // Methods
    public void DisplayResume()
    {
        Console.WriteLine($"{Name}");
        foreach (var job in Job)
        {
            Console.WriteLine($"{job}");
        }
    }

}