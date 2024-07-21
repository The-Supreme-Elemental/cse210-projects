public class ReceptionEvent : Event
{
    private string _contactRSVP;

    public ReceptionEvent(string title, string desc, Address address, string date, string time, string contactRSVP) : base(title, desc, address, date, time)
    {
        _contactRSVP = contactRSVP;
    }

    public string GetFullDetails()
    {
        string details = GetStandardDetails();
        details += $"\n\nPlease RSVP at this email, @{_contactRSVP}!";
        return details;
    }


}