
public class Entries
{
    
    public string _prompt;
    public string _response;
    DateTime _date = DateTime.Now;
    // string dateText = date.ToShortDateString();

    public Entries(DateTime date, string prompt, string response="") {
        _response = response;
        _date = date;
        _prompt = prompt;


    }

    public string InputEntry() {

        Prompt prompt = new Prompt();
        _prompt = prompt.GivePrompt();
        Console.WriteLine(_prompt);

        Console.WriteLine("Please write your entry below. ");
        string response = Console.ReadLine();
        _response = response;
        return response;
        

    }

    public string GetEntry()
    {
        return $"{this.GetdateText()} ~|~ {this._prompt} ~|~ {this._response}\n";
    }

    

    public string GetdateText() {
        DateTime date = _date;
        string dateText = date.ToShortDateString();
        return dateText;
    }



}