public abstract class Activity
{
    protected string _date;
    protected int _lenghtminutes;

    public Activity(string date, int lenghtminutes)
    {
        _date = date;
        _lenghtminutes = lenghtminutes;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{_date} Activity({_lenghtminutes}minutes.)";
    }
}