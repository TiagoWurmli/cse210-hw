using System;
using System.Net.Http.Headers;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Anytown", "CA", "12345");
        Custumer customer1 = new Custumer("John Doe", address1);
        Product product1 = new Product("Widget", "123", 19.99, 2);
        Product product2 = new Product("Gadget", "456", 29.99, 1);
        Product product3 = new Product("Thingamajig", "789", 9.99, 5);
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        string packingLabel1 = order1.GetPackingLabel();
        string shippingLabel1 = order1.GetShippingLabel();
        double orderTotal1 = order1.GetOrderTotalCost();

        Console.WriteLine(packingLabel1);
        Console.WriteLine(shippingLabel1);
        Console.WriteLine($"Total Cost: {orderTotal1:C}");
    }
}