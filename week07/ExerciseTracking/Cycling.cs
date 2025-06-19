public class Cycling : Activity
{
    private double _speed;

    public Cycling(string data, int lenghtminutes, double speed) : base(data, lenghtminutes)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return _speed * _lenghtminutes / 60.0;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }

    public override string GetSummary()
    {
        return $"{_date} Cycling({_lenghtminutes} minutes): Distance{GetDistance():0.0}km, Speed{GetSpeed():0.0} kph, Pace: {GetPace():0.0} min per km";
    }
}