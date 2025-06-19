public class Running : Activity
{
    private double _distance;

    public Running(string date, int lenghtminutes, double distance) : base(date, lenghtminutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _distance / _lenghtminutes * 60;
    }

    public override double GetPace()
    {
        return _lenghtminutes / _distance;
    }

    public override string GetSummary()
    {
        return $"{_date} Running ({_lenghtminutes} minutes): Distance {_distance} km, Speed {GetSpeed():0.0} kph, Pace: {GetPace():0.0} min per km";
    }
}