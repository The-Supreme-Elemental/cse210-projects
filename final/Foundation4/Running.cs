public class Running : Activity
{
    private double _distance;

    public Running(double distance, string date, double minutes) : base(date, minutes) 
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / _minutes) * 60;
    }

    public override double GetPace()
    {
        return 60 / GetSpeed();
    }
    public override string GetSummary()
    {
        return $"{_date} Running ({_minutes} minutes) - {GetDistance()} miles, {GetSpeed()} mph, Pace: {GetPace()} min per mile.";
    }
}