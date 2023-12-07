public class Reception : Event
{
    // attributes
    private string _email;

    // constructor
    public Reception(string title, string description, string date, string time, string address, string email) : base("Reception", title, description, date, time, address)
    {
        _email = email;
    }

    // methods

    public string GetRSVPMessage()
    {
        return $"Please send an email RSVP to {_email}";
    }

    public override string GetFullDetails()
    {
        return $"{_eventType}\n{GetStandardDetails()}\n{GetRSVPMessage()}";
    }

}