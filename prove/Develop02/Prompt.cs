
public class Prompt
// Define the class Promp
{
    // Create the empty list _listOfPrompt
    public List<string> _listOfPrompt = new List<string>();
        // Storing the random prompt 
    public string _prompt;

    // This is where several different prompts are laid out, where we will pick one 
    // randomly and return it to the user. 
    public string GivePrompt()
    {
        _listOfPrompt.Add("Who was the most interesting person I interacted with today?");
        _listOfPrompt.Add("What was the best part of my day?");
        _listOfPrompt.Add("How did I see the hand of the Lord in my life today?");
        _listOfPrompt.Add("What was the strongest emotion I felt today?");
        _listOfPrompt.Add("If I had one thing I could do over today, what would it be?");
        _listOfPrompt.Add("What was something today that made me smile?");

        // This \/ stores the prompt, which then picks randomly from here and returns the prompt.  ^^
        Random random = new Random();
        int number = random.Next(_listOfPrompt.Count());
        _prompt = _listOfPrompt[number];
        return _listOfPrompt[number];

        
    }
}
