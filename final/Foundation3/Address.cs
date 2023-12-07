public class Address
{
    // attributes
    private string _street;
    private string _city;
    private string _state;
    private string _zip;

    // constructor
    public Address(string street, string city, string state, string zip)
    {
        _street = street;
        _city = city;
        _state = state;
        _zip = zip;
    }

    // methods
    public string GetStreet()
    {
        return _street;
    }

    public string GetCity()
    {
        return _city;
    }

    public string GetState()
    {
        return _state;
    }

    public string GetZip()
    {
        return _zip;
    }

    public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_state} {_zip}";
    }
}