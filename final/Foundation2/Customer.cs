public class Customer
{
    // attributes
    private string _name;
    private Address _shippingAddress;

    // constructor
    public Customer(string name, Address shippingAddress)
    {
        _name = name;
        _shippingAddress = shippingAddress;
    }

    // methods
    public Address GetShippingAddress()
    {
        return _shippingAddress;
    }
    public string GetName()
    {
        return _name;
    }
    public bool IsInUSA()
    {
        return _shippingAddress.GetCountry() == "USA";
    }
}