public class Product
{
    // attributes
    private string _name;
    private int _productId;
    private double _price;
    private int _quantity;

    // constructor
    public Product(string name, int productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }
    
    // methods
    public double GetPrice()
    {
        return _price * _quantity;
    }
    public string GetName()
    {
        return _name;
    }
    public int GetProductId()
    {
        return _productId;
    }
    public int GetQuantity()
    {
        return _quantity;
    }

}