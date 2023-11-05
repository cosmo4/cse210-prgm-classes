public class Activity
{
    // Attributes
    protected string ActivityName { get; set; }
    protected string StartingMessage { get; set; }
    protected string Description { get; set; }
    protected internal int Duration { get; set; }
    protected string EndingMessage { get; set; }

    // Constructors
    public Activity()
    {
        ActivityName = "";
        StartingMessage = "";
        Description = "";
        Duration = 0;
        EndingMessage = "";
    }
    public Activity(string ActivityName, string Description, int Duration)
    {
        this.ActivityName = ActivityName;
        StartingMessage = $"You have selected the {ActivityName}. {Description}";
        this.Description = Description;
        this.Duration = Duration;
        EndingMessage = $"Good job!!! You have just completed the {ActivityName}.";
    }

    // Methods
    public int GetUserTime()
    {
        Console.WriteLine($"How long would you like to do the {ActivityName}? (in seconds): ");
        Duration = int.Parse(Console.ReadLine());
        Console.WriteLine($"Great! Your {ActivityName} will last for {Duration} seconds. Please get ready to start.");
        return Duration;
    }

    public void DisplayStartMessage()
    {
        Console.WriteLine($"{StartingMessage}");
    }
    
    public void DisplayEndMessage()
    {
        Console.WriteLine($"{EndingMessage}");
    }
    
}