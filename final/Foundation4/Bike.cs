public class Bike : Activity
{
    // Attributes
    private double _speed;

    // Constructor
    public Bike(string date, int duration, double speed) : base("Biking", date, duration)
    {
        _date = date;
        _duration = duration;
        _speed = speed;
    }

    // Methods
    public override double CalcDistance()
    {
        double distance;
        distance = _speed * (_duration / 60.0);
        return distance;
    }

    public override double CalcSpeed()
    {
        return _speed;
    }

    public override double CalcPace()
    {
        double pace;
        pace = _duration / CalcDistance();
        return pace;
    }

    public override string GetSummary()
    {
        string summary = $"{_date} {_type} ({_duration} min)- Distance {CalcDistance():0.0} miles, Speed: {_speed:0.0} mph, Pace: {CalcPace():0.00} min/mile";
        return summary;
    }
}