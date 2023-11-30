using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        // create addresses
        Address address1 = new Address("123 Main St", "Smalltown", "ID", "USA");
        Address address2 = new Address("321 Sesame St", "Birdy", "Paris", "France");

        // create customers
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Marie Antoniette", address2);

        // create products
        Product product1 = new Product("iPhone 10 Case", 1, 25.00, 1);
        Product product2 = new Product("iPhone 10", 2, 500.00, 1);
        Product product3 = new Product("iPhone 10 Screen Protector", 3, 15.00, 2);
        Product product4 = new Product("Garden Gloves", 4, 10.00, 2);
        Product product5 = new Product("Sprinkler Toolkit", 5, 35.00, 1);

        // create orders
        Order order1 = new Order(new List<Product> { product1, product2, product3 }, customer2);
        Order order2 = new Order(new List<Product> { product4, product5 }, customer1);

        // print order details
        Console.WriteLine("Order Details:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Packing List:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine($"Total: ${order1.GetTotal()}");
        Console.WriteLine();
        Console.WriteLine("Order Details:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Packing List:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine($"Total: ${order2.GetTotal()}");
    }
}