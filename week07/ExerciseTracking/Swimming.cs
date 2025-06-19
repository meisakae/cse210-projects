public class Swimming : Activity
{
    private int _laps;

    public Swimming(string data, int lenghtminutes, int laps) : base(data, lenghtminutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000.0;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / _lenghtminutes) * 60;
    }

    public override double GetPace()
    {
        return _lenghtminutes / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{_date} Swimmming ({_lenghtminutes} minutes): Distance {GetDistance} km, Speed {GetSpeed():0.0} kph, Pace: {GetPace():0.0} min per km";
    }
}