using System;
public class BreathingActivity : Activity
{
    public BreathingActivity()
    : base(
        "Breathing Activity",
        "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.",
        0)
    {

    }

    public void Run()
    {
        DispayStartingMessage();

        int duration = GetDuration();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(10);

        while (DateTime.Now < futureTime)
        {
            Console.WriteLine("\n Breathe in...");
            ShowCountDown(5);

            Console.WriteLine("\n Breathe out...");
            ShowCountDown(5);
        }

        DispayEndingMessage();
    }
}