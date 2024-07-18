public class ChecklistGoal : AGoal
{
    private bool _complete;
    private int _bonusThreshold; //Number of times activity needs to be completed before bonus
    private int _bonusScore;
    private int _numberAwarded; //Number of times out of _bonusThreshold

    public ChecklistGoal(string title, string desc, int score, int bonusScore, int bonusThreshold) : base(title, desc)
    {
        _score = score;
        _bonusScore = bonusScore;
        _bonusThreshold = bonusThreshold;
        _complete = false;
    }

    public override void Award()
    {

    }

    public override void Display()
    {
        string mark;
        if (_complete == true)
        {
            mark = "[x]";
        }
        else
        {
            mark = "[ ]";
        }
        Console.WriteLine($"{mark} {_title}: ({_desc}) Completed {_numberAwarded}/{_bonusThreshold}");

    }

    public override string GetStringRepresentation()
    {
        string stringRepresentation = "";

        return stringRepresentation;
    }
}