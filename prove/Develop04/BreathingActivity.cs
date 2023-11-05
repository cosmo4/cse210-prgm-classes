public class BreathingActivity : Activity
{

    public BreathingActivity()
        : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", 0)
    {
        ActivityName = "Breathing Activity";
        Description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
        
    }
    // Behaviors/Methods
    public void BreatheIn()
    {
        Console.Write("Breathe in...");
        
        for (int i = 1; i <= 6; i ++)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }

    public void BreatheOut()
    {
        Console.Write("Breathe out...");

        for (int i = 6; i >= 1; i --)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }
}