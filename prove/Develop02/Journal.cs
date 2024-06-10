
public class Journal 
{
    Entries _entries = new Entries();
    // This is a list with strings in it. 
    public List<Entries> _listOfResponses = new List<Entries>();
    public List<string> _listOfDates = new List<string>();

    public Journal() {

    }

    public void DisplayJournal()
    {
        string date = _entries.GetdateText();
        Console.WriteLine($"{date}");
    }



}