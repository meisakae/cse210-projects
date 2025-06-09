using System;
public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
    };
    private List<string> _question = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
    };

    public ReflectionActivity()
        : base(
            "ReflectionActivity",
            "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",
            0
        )
    {
    }

    public void Run()
    {
        DispayStartingMessage();
        Console.WriteLine();

        DisplayPrompt();
        ShowCountDown(3);

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            DispayQuestion();
            ShowSpinner(3);
        }

        DispayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int rand = random.Next(_prompts.Count);
        return _prompts[rand];
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        int rand = random.Next(_question.Count);
        return _question[rand];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine($"---{GetRandomPrompt()}---");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they relatesd to this experience.");
        Console.WriteLine("You may begin in: ");
        ShowCountDown(3);
    }

    public void DispayQuestion()
    {
        string questions = GetRandomQuestion();
        Console.WriteLine($"> {questions}");
    }
}