public class Order
{
    private List<Product> _products;
    private Custumer _customer;

    public Order(Custumer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public double GetOrderTotalCost()
    {
        double totalPrice = 0;
        foreach (Product product in _products)
        {
            totalPrice += product.GetTotalPrice();
        }
        if (_customer.IsInUSA())
        {
            totalPrice += totalPrice + 5;
        }
        else
        {
            totalPrice += totalPrice + 35;
        }
        return totalPrice;
    }
    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";
        foreach (Product product in _products)
        {
            packingLabel += $"Product: {product.GetName()} - ID: {product.GetProductId()}\n";
        }
        return packingLabel;
    }
    public string GetShippingLabel()
    {
        string shippingLabel = "Shipping Label:\n";
        shippingLabel += $"{_customer.GetName()}\n";
        shippingLabel += $"{_customer.GetAddress().GetFullAddress()}\n";
        return shippingLabel;
    }
}