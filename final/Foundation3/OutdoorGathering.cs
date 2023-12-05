public class OutdoorGathering : Event
{
    // attributes
    private string weather;

    // constructor
    public OutdoorGathering(string title, string description, string date, string time, string address, string weather) : base("Outdoor Gathering", title, description, date, time, address)
    {
        this.weather = weather;
    }

    // methods
    public string GetWeather()
    {
        return weather;
    }

    public override string GetFullDetails()
    {
        return $"{eventType}\n{GetStandardDetails()}\n{weather}";
    }
}