public class Assignment
{
    private string _studnentName;
    private string _topic;

    public Assignment(string studnentName, string topic)
    {
        _studnentName = studnentName;
        _topic = topic;
    }

    public string GetStudentName()
    {
        return _studnentName;
    }

    public string GetTopic()
    {
        return _topic;
    }

    public string GetSummary()
    {
        return _studnentName + " - " + _topic;
    }
}