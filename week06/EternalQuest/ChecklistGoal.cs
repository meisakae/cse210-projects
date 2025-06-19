using System;
using System.Collections.Generic;
public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        if (!IsComplete())
        {
            _amountCompleted++;
            Console.WriteLine($"You earned {_points} points!");

            if (IsComplete())
            {
                Console.WriteLine($"Congratulations! You have earned {_bonus} points!");
                return _points + _bonus;
            }

            return _points;
        }
        else
        {
            Console.WriteLine("This goal has already been completed.");
            return 0;
        }

    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetaiIsString()
    {
        string checkbox = IsComplete() ? "[x]" : "[]";
        return $"{checkbox} {_shortName} ({_description}) -- Completed {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName},{_description},{_points},{_amountCompleted},{_target},{_bonus}";
    }

    public int GetBonusPoints()
    {
        return _bonus;
    }

    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }

    public void GetAmountCompleted(int amount)
    {
        _amountCompleted = amount;
    }
}