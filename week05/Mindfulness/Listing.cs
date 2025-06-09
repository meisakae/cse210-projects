using System;
using System.Runtime.CompilerServices;
public class ListingActivity : Activity
{

    private int _count;
    private List<string> _response = new List<string>();
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
    : base(
        "ListingActivity",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",
        0
    )
    {

    }

    public void Run()
    {
        DispayStartingMessage();

        Console.WriteLine("List as many responses you can to the following prompt: ");
        Console.WriteLine($"---{GetRandomPrompt()}---");
        Console.WriteLine("You may being in: ");
        ShowCountDown(3);

        _response = GetListFromUser();
        _count = _response.Count;

        Console.WriteLine($"you listied {_count} items!");
        DispayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(_prompts.Count)];
    }

    public List<string> GetListFromUser()
    {
        List<string> item = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            if (input != "")
            {
                item.Add(input);
            }
        }
        return item;
    }
}

