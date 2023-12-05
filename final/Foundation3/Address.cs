public class Address
{
    // attributes
    private string street;
    private string city;
    private string state;
    private string zip;

    // constructor
    public Address(string street, string city, string state, string zip)
    {
        this.street = street;
        this.city = city;
        this.state = state;
        this.zip = zip;
    }

    // methods
    public string GetStreet()
    {
        return street;
    }

    public string GetCity()
    {
        return city;
    }

    public string GetState()
    {
        return state;
    }

    public string GetZip()
    {
        return zip;
    }

    public string GetFullAddress()
    {
        return $"{street}\n{city}, {state} {zip}";
    }
}