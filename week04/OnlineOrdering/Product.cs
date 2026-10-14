public class Product
{
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }
    public void DisplayProduct()
    {
        Console.WriteLine($"Product Name: {_name}");
        Console.WriteLine($"Product ID: {_productId}");
        Console.WriteLine($"Price: {_price}");
        Console.WriteLine($"Quantity: {_quantity}");
    }
    public double GetTotalPrice()
    {
        return _price * _quantity;
    }
    public int GetQuantity()
    {
        return _quantity;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetProductId()
    {
        return _productId;
    }
    public double GetPrice()
    {
        return _price;
    }
}