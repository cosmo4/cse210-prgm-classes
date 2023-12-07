public class Run : Activity
{
    // Attributes
    private double _distance;

    // Constructor
    public Run(string date, int duration, double distance) : base("Running", date, duration)
    {
        _date = date;
        _duration = duration;
        _distance = distance;
    }

    // Methods
    public override double CalcDistance()
    {
        return _distance;
    }

    public override double CalcSpeed()
    {
        double speed;
        // duration is in minutes, so we need to convert to hours
        speed = _distance / (_duration / 60.0);
        return speed;
    }

    public override double CalcPace()
    {
        double pace;
        pace = _duration / _distance;
        return pace;
    }

    public override string GetSummary()
    {
        string summary = $"{_date} {_type} ({_duration} min)- Distance {_distance} miles, Speed: {CalcSpeed():0.0} mph, Pace: {CalcPace():0.00} min/mile";
        return summary;
    }
}