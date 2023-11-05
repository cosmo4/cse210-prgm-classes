using System.Diagnostics;

public class ListingActivity : Activity
{
    // Attributes
    private List<string> PromptList;
    private List<string> ResponsesList;
    private int ResponseCount;
    private Random random = new();
    
    // Constructors
    public ListingActivity()
    : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 0)
    {
        ActivityName = "Listing Activity";
        Description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

        PromptList = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

    }

    // Methods
    public string GetPrompt()
    {
        int randomIndex = random.Next(PromptList.Count);
        return PromptList[randomIndex];
    }

    public List<string> GenerateResponseList(int duration)
    {
        List<string> ResponsesList = new();

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        while (stopwatch.Elapsed.TotalSeconds < duration)
        {
            Console.Write("> ");
            string Response = Console.ReadLine();

            if (string.IsNullOrEmpty(Response))
            {
                break;
            }

            ResponsesList.Add(Response);
        }
        return ResponsesList;
    }
}