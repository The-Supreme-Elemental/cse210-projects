
using System.Net;
using System.Xml.XPath;

public class Journal
{
    // Entries _entries = new Entries(DateTime.Now, "");
    // This is a list with strings in it. 
    public List<Entries> _listOfResponses = new List<Entries>();

    public Journal()
    {

    }

    public void DisplayJournal()
    {
        foreach (Entries response in _listOfResponses)
        {
            Console.WriteLine($"{response.GetEntry()}");

        }
    }

    public void appendToJournal(Entries entry)
    {
        _listOfResponses.Add(entry);

    }

    public string SaveJournal()
    {
        string result = "";
        foreach (Entries response in _listOfResponses)
        {
            result += response.GetEntry();

        }
        return result;
    }



}