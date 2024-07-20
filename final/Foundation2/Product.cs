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
}