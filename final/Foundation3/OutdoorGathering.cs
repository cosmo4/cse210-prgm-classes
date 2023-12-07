public class OutdoorGathering : Event
{
    // attributes
    private string _weather;

    // constructor
    public OutdoorGathering(string title, string description, string date, string time, string address, string weather) : base("Outdoor Gathering", title, description, date, time, address)
    {
        _weather = weather;
    }

    // methods
    public string GetWeather()
    {
        return _weather;
    }

    public override string GetFullDetails()
    {
        return $"{_eventType}\n{GetStandardDetails()}\n{_weather}";
    }
}