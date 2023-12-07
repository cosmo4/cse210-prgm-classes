public class Swim : Activity
{
    // Attributes
    private double _numLaps;

    // Constructor
    public Swim(string date, int duration, double numLaps) : base("Swimming", date, duration)
    {
        _date = date;
        _duration = duration;
        _numLaps = numLaps;
    }

    // Methods
    public override double CalcDistance()
    {
        double distance;
        distance = _numLaps * 50 / 1000 * 0.62;
        return distance;
    }

    public override double CalcSpeed()
    {
        double speed;
        speed = CalcDistance() / _duration * 60.0;
        return speed;
    }

    public override double CalcPace()
    {
        double pace;
        pace = _duration / CalcDistance();
        return pace;
    }

    public override string GetSummary()
    {
        string summary = $"{_date} {_type} ({_duration} min)- Distance {CalcDistance():0.0} miles, Speed: {CalcSpeed():0.0} mph, Pace: {CalcPace():0.00} min/mile";
        return summary;
    }
}