
public class Entries
{
    
    public string _prompt;
    DateTime _date = DateTime.Now;
    // string dateText = date.ToShortDateString();

    public Entries(string _date, string _prompt) {
        
    }

    public Entries() {
        
    }

    public string GetdateText() {
        DateTime date = _date;
        string dateText = date.ToShortDateString();
        return dateText;
    }



}