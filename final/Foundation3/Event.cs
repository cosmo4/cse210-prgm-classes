public abstract class Event
{
    // attributes/properties
    protected string eventType;
    protected string eventTitle;
    protected string eventDescription;
    protected string eventDate;
    protected string eventTime;
    protected string eventAddress;

    // constructor
    public Event(string type, string title, string description, string date, string time, string address)
    {
        eventType = type;
        eventTitle = title;
        eventDescription = description;
        eventDate = date;
        eventTime = time;
        eventAddress = address;
    }

    // methods
    public string GetEventTitle()
    {
        return eventTitle;
    }

    public string GetEventDescription()
    {
        return eventDescription;
    }

    public string GetEventDate()
    {
        return eventDate;
    }

    public string GetEventTime()
    {
        return eventTime;
    }

    public string GetEventAddress()
    {
        return eventAddress;
    }

    public string GetStandardDetails()
    {
        return $"{eventTitle}\n{eventDescription}\n{eventDate}\n{eventTime}\n{eventAddress}";
    }
    public string GetShortDescription()
    {
        return $"{eventType} - {eventTitle} - {eventDate}";
    }

    public abstract string GetFullDetails();
}