public class Order
{
    private List<Product> _products = new List<Product>();

    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}: {_customer.GetAddress()}";
    }

    public string GetTotalCost()
    {
        decimal totalCost = 0;
        foreach (Product product in _products)
        {
            totalCost = totalCost + product.GetCost();
        }
        if (_customer.DomesticUSA() == true)
        {
            totalCost = totalCost + 5;
        }
        else
        {
            totalCost = totalCost + 35;
        }
        return $"Your total is: ${totalCost}.";
    }

    public void AddItem(Product product)
    {
        _products.Add(product);
    }

    public void GetPackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in _products)
        {
            packingLabel = $"{product.GetProductName().ToUpper()} - {product.GetProductID()}";
            Console.WriteLine(packingLabel);
        }
        // return packingLabel;
    }
}