public abstract class Activity
{
    // Attributes
    protected string _type;
    protected string _date;
    protected int _duration;

    // Constructor
    public Activity(string type, string date, int duration)
    {
        _type = type;
        _date = date;
        _duration = duration;
    }

    // Methods
    public abstract double CalcDistance();
    public abstract double CalcSpeed();
    public abstract double CalcPace();
    public abstract string GetSummary();
}