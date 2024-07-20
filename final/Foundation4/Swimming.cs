public class Swimming : Activity
{
    private uint _laps;

    public Swimming(uint laps, string date, double minutes) : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50.0 / 1000.0 * 0.62;
    }

    public override double GetPace()
    {
        return _minutes / GetDistance();
    }

    public override double GetSpeed()
    {
        return (GetDistance() / _minutes) * 60;
    }

    public override string GetSummary()
    {
        return $"{_date} Swimming ({_minutes} minutes) - {GetDistance()} miles, {GetSpeed()} mph, Pace: {GetPace()} min per mile.";
    }
}
