public class Event
{
    protected string _title;
    private string _desc;
    private Address _address;
    protected string _date;
    private string _time;

    public Event(string title, string desc, Address address, string date, string time)
    {
        _title = title;
        _desc = desc;
        _date = date;
        _time = time;
        _address = address;
        
    }

    public string GetStandardDetails()
    {
        return $"{_title}, {_desc}, {_date}. {_time}, \n{_address.GetAddressLabel()}.";
    }
}