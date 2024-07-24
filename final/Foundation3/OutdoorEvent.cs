public class OutdoorEvent : Event
{
    private string _weatherStatement;

    public OutdoorEvent(string title, string desc, Address address, string date, string time, string weatherStatement) : base(title, desc, address, date, time)
    {
        _weatherStatement = weatherStatement;
    }

    public string GetFullDetails()
    {
        string details = GetStandardDetails();
        details += $"\n \nThe weather is going to be {_weatherStatement}";
        return details;
    }

    public string GetShortDetails()
    {
        return $"Outdoor Event: {_title}. {_date}.";
    }
}
