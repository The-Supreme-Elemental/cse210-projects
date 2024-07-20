public class LectureEvent : Event
{
    private string _speaker;
    private uint _capacity;

    public LectureEvent(string title, string desc, Address address, string date, string time, string speaker, uint capacity) : base(title, desc, address, date, time)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public string GetFullDetails()
    {
        string details = GetStandardDetails();
        details += $"\n \n{_speaker}, {_capacity} attendees.";
        return details;
    }

    public string GetShortDetails()
    {
        return $"Lecture: {_title}. {_date}.";
    }


}