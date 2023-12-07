public class Run : Activity
{
    // Attributes
    private double Distance;

    // Constructor
    public Run(string date, int duration, double distance) : base("Running", date, duration)
    {
        Date = date;
        Duration = duration;
        Distance = distance;
    }

    // Methods
    public override double CalcDistance()
    {
        return Distance;
    }

    public override double CalcSpeed()
    {
        double speed;
        // duration is in minutes, so we need to convert to hours
        speed = Distance / (Duration / 60.0);
        return speed;
    }

    public override double CalcPace()
    {
        double pace;
        // duration is in minutes, so we need to convert to hours
        pace = (Duration / 60.0) / Distance;
        return pace;
    }

    public override string GetSummary()
    {
        string summary;
        summary = "Type: " + Type + "\n" +
                  "Date: " + Date + "\n" +
                  "Duration: " + Duration + " minutes\n" +
                  "Distance: " + Distance + " miles\n" +
                  "Speed: " + CalcSpeed() + " mph\n" +
                  "Pace: " + CalcPace() + " minutes per mile\n";
        return summary;
    }
}