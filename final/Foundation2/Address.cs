public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;
    private int _zipCode;

    public Address(string streetAddress, string city, string stateOrProvince, string country, int zipCode)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
        _zipCode = zipCode;
    }

    public bool IsDomesticUSA()
    {
        bool isDomestic = false;

        // Console.Write("Is this package going in or outside of the US? (inside/outside)");
        // string userInput = Console.ReadLine();
        // if (userInput == "inside")
        if (_country == "USA")
        {
            isDomestic = true;

        } else {
            isDomestic = false;
        }
        return isDomestic;
    }

    public string GetAddressLabel()
    {
        return $"{_streetAddress}\n{_city}, {_stateOrProvince} {_zipCode}\n{_country.ToUpper()}";
    }
}