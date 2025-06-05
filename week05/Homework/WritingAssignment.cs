public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studnentName, string topic, string title)
        : base(studnentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        string studnentName = GetStudentName();

        return $"{_title} by {studnentName}";
    }

}