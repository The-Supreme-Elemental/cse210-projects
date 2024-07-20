using System.Linq.Expressions;

public class Cycling : Activity
{
    private double _speed;

    public Cycling(double speed, string date, double minutes) : base(date, minutes)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return (GetSpeed() / 60) * _minutes;
    }

    public override double GetPace()
    {
        return _minutes / GetDistance();
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override string GetSummary()
    {
        return $"{_date} Cycling ({_minutes} minutes) - {GetDistance()} miles, {GetSpeed()} mph, Pace: {GetPace()} min per mile.";
    }
}