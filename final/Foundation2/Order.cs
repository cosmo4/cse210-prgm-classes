public class Order
{
    // attributes
    private List<Product> products = new();
    private Customer customer;

    // constructor
    public Order(List<Product> products, Customer customer)
    {
        this.products = products;
        this.customer = customer;
    }

    // methods
    public double GetTotal()
    {
        double total = 0;
        foreach (Product product in products)
        {
            total += product.GetPrice();
        }
        if (customer.IsInUSA())
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
        return $"{customer.GetName()}\n{customer.GetShippingAddress().GetFullAddress()}";
    }
    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in products)
        {
            packingLabel += $"Name: {product.GetName()}, ID: {product.GetProductId()}, Quantity: {product.GetQuantity()}\n";
        }
        return packingLabel;
    
    }

}