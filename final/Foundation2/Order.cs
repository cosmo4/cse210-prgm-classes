public class Order
{
    // attributes
    private List<Product> _products = new();
    private Customer _customer;

    // constructor
    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    // methods
    public double GetTotal()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.GetPrice();
        }
        if (_customer.IsInUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }
        return total;
    }
    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetShippingAddress().GetFullAddress()}";
    }
    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in _products)
        {
            packingLabel += $"Name: {product.GetName()}, ID: {product.GetProductId()}, Quantity: {product.GetQuantity()}\n";
        }
        return packingLabel;
    
    }

}