public class Order
{
    private List<Product> _products = new List<Product>();

    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public string GetShippingLabel()
    {
        return $"{_customer}: {_customer.GetAddress()}";
    }

    public string GetTotalCost()
    {
        return $"Your total is: ${GetTotalCost()}";
    }
}