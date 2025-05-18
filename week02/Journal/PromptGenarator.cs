public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "What was the favorite part of your day and why?",
        "what did you learn from people around you?",
        "How did the Load help or bless you today?",
        "What are three things you're thankful for today?",
        "What is one thing you'd like to improve tomorrow based on today?"
    };

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }
}