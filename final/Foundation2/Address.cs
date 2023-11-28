public class Address
{
    // attributes
    private string _street;
    private string _city;
    private string _stateProvince;
    private string _country;

    // constructor
    public Address(string street, string city, string stateProvince, string country)
    {
        _street = street;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    // methods
    public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_stateProvince} {_country}";
    }
    public string GetCountry()
    {
        return _country;
    }
    
}