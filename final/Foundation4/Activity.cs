public abstract class Activity
{
    // Attributes
    protected string Type;
    protected string Date;
    protected int Duration;

    // Constructor
    public Activity(string type, string date, int duration)
    {
        Type = type;
        Date = date;
        Duration = duration;
    }

    // Methods
    public abstract double CalcDistance();
    public abstract double CalcSpeed();
    public abstract double CalcPace();
    public abstract string GetSummary();
}