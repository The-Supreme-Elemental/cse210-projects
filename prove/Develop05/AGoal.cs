using System.ComponentModel.DataAnnotations;
using System.Security;

public abstract class AGoal
{
    protected string _title;
    protected string _desc;
    protected int _score;
    private int _cumulativeScore;


    public AGoal(string title, string desc)
    {
        _title = title;
        _desc = desc;
    }

    public int GetCumulativeScore()
    {
        return _cumulativeScore;
    }
    
    public abstract void Award();

    public abstract void Display();
    public abstract string GetStringRepresentation();

}