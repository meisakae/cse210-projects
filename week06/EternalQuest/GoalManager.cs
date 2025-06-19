using System;
using System.IO;
public class GoalManager
{
    private List<Goal> _goal = new List<Goal>();
    private int _score = 0;

    public GoalManager()
    {
    }

    public void Start()
    {
        string choice = "";
        while (choice != "6")
        {
            Console.WriteLine("Mene Option: ");
            Console.WriteLine("1. Create New Goals");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.WriteLine("Select an option: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                CreateGoal();
            }
            else if (choice == "2")
            {
                ListGoalDetails();
            }
            else if (choice == "3")
            {
                SaveGoals();
            }
            else if (choice == "4")
            {
                LoadGoals();
            }
            else if (choice == "5")
            {
                RecordEvent();
            }
            else if (choice == "6")
            {
                Console.WriteLine("Exiting program..");
            }
            else
            {
                Console.WriteLine("Invalid selected.");
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points!");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("Your Goals: ");

        if (_goal.Count == 0)
        {
            Console.WriteLine("You not have goals created yet.");
        }
        else
        {
            int i = 1;
            foreach (Goal goal in _goal)
            {
                Console.WriteLine($"{i}. {goal.GetShortName}");
                i++;
            }
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("The Goals are:");

        if (_goal.Count == 0)
        {
            Console.WriteLine("No goals habe been created yet.");
        }

        else
        {
            int i = 1;
            foreach (Goal goal in _goal)
            {
                Console.WriteLine($"{i}.{goal.GetDetaiIsString()}");
                i++;
            }
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are: ");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create?: ");
        string goalType = Console.ReadLine();

        Console.Write("what is the name of your gaol?: ");
        string name = Console.ReadLine();

        Console.Write("What is a short description if it?: ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal?: ");
        int points = int.Parse(Console.ReadLine());

        if (goalType == "1")
        {
            SimpleGoal goal = new SimpleGoal(name, description, points);
            _goal.Add(goal);
        }

        else if (goalType == "2")
        {
            EternalGoal goal = new EternalGoal(name, description, points);
            _goal.Add(goal);
        }

        else if (goalType == "3")
        {
            Console.Write("How many times  does this goal need to be accomplished for a bonus?: ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for accomplishing it that mamy times?: ");
            int bonus = int.Parse(Console.ReadLine());

            ChecklistGoal goal = new ChecklistGoal(name, description, points, target, bonus);
            _goal.Add(goal);
        }

        else
        {
            Console.WriteLine("Invalid goal type selected.");
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("Which goal did you accomplished?: ");

        for (int i = 0; i < _goal.Count; i++)
        {
            Console.WriteLine($"{i + 1}. (_goal[i].GetShortName()");
        }

        Console.Write("Enter the number of the goal: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < _goal.Count)
        {
            int pointsEarned = _goal[index].RecordEvent();
            _score += pointsEarned;
            Console.WriteLine($"You earned {pointsEarned} points!");
            Console.WriteLine($"Total score: {_score}");
        }
        else
        {
            Console.WriteLine("Invalis selected.");
        }
    }

    public void SaveGoals()
    {
        string filename = "myfile.txt";

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);

            foreach (Goal goal in _goal)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals and score saved to myfile.txt.");

    }

    public void LoadGoals()
    {
        string filename = "myfile.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);
        _goal.Clear();

        _score = int.Parse(lines[0]);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string goalType = parts[0];

            if (goalType == "SimpleGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                bool IsComplete = bool.Parse(parts[4]);

                SimpleGoal goal = new SimpleGoal(name, description, points);
                if (IsComplete)
                {
                    goal.Complete();
                }
                _goal.Add(goal);
            }

            else if (goalType == "EternalGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);

                EternalGoal goal = new EternalGoal(name, description, points);
                _goal.Add(goal);
            }

            else if (goalType == "ChecklistGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                int amount = int.Parse(parts[4]);
                int target = int.Parse(parts[5]);
                int bonus = int.Parse(parts[6]);

                ChecklistGoal goal = new ChecklistGoal(name, description, points, amount, target);
                goal.GetAmountCompleted(0);

                _goal.Add(goal);
            }
        }

        Console.WriteLine("Goal loaded fromg file.");
    }

    public int GetScore()
    {
        return _score;
    }
}