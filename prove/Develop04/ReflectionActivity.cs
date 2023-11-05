public class ReflectionActivity : Activity
{
    // Attributes
    private List<string> PromptList { get; set; }
    private List<string> ReflectQuestionsList { get; set; }
    private Random random = new();

    // Constructor
    public ReflectionActivity()
    : base("Reflection Activity",
        "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 0)
    {
        ActivityName = "Reflection Activity";
        Description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

        PromptList = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless"
        };

        ReflectQuestionsList = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

    }

    // Methods
    public string GetPrompt()
    {
        int randomIndex = random.Next(PromptList.Count);
        return PromptList[randomIndex];
    }

    public string GetReflectQuestion()
    {
        int randomIndex = random.Next(ReflectQuestionsList.Count);
        return ReflectQuestionsList[randomIndex];
    }

}