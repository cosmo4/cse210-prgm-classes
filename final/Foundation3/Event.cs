public abstract class Event
{
    // attributes/properties
    protected string _eventType;
    protected string _eventTitle;
    protected string _eventDescription;
    protected string _eventDate;
    protected string _eventTime;
    protected string _eventAddress;

    // constructor
    public Event(string type, string title, string description, string date, string time, string address)
    {
        _eventType = type;
        _eventTitle = title;
        _eventDescription = description;
        _eventDate = date;
        _eventTime = time;
        _eventAddress = address;
    }

    // methods
    public string GetEventTitle()
    {
        return _eventTitle;
    }

    public string GetEventDescription()
    {
        return _eventDescription;
    }

    public string GetEventDate()
    {
        return _eventDate;
    }

    public string GetEventTime()
    {
        return _eventTime;
    }

    public string GetEventAddress()
    {
        return _eventAddress;
    }

    public string GetStandardDetails()
    {
        return $"{_eventTitle}\n{_eventDescription}\n{_eventDate}\n{_eventTime}\n{_eventAddress}";
    }
    public string GetShortDescription()
    {
        return $"{_eventType} - {_eventTitle} - {_eventDate}";
    }

    public abstract string GetFullDetails();
}