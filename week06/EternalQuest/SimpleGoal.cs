using System;
public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return _points;
        }

        return 0;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_shortName},{_description},{_points},{_isComplete}";
    }

    public override string GetDetaiIsString()
    {
        string checkbox = _isComplete ? "[x]" : "[ ]";
        return $"{checkbox} {_shortName} ({_description})";
    }

    public void Complete()
    {
        _isComplete = true;
    }
}