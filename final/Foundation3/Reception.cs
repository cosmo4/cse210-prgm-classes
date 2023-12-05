public class Reception : Event
{
    // attributes
    private string email;

    // constructor
    public Reception(string title, string description, string date, string time, string address, string email) : base("Reception", title, description, date, time, address)
    {
        this.email = email;
    }

    // methods

    public string GetRSVPMessage()
    {
        return $"Please send an email RSVP to {email}";
    }

    public override string GetFullDetails()
    {
        return $"{eventType}\n{GetStandardDetails()}\n{GetRSVPMessage()}";
    }

}