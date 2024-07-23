public class Product
{
    private string _name;
    private string _id;
    private decimal _pricePerUnit;
    private int _quantity;

    public Product(string name, string id, decimal pricePerUnit, int quantity)
    {
        _name = name;
        _id = id;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;
    }

    public decimal TotalCost()
    {
        return _pricePerUnit * _quantity;
    }

    public string GetProductName()
    {
        return _name;
    }

    public string GetProductID()
    {
        return _id;
    }

    public decimal GetCost()
    {
        return _pricePerUnit;
    }

}