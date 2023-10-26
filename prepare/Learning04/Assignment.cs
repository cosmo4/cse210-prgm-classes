public class Assignment
{
    protected string StudentName { get; set; }
    protected string Topic { get; set; }

    public Assignment()
    {
        StudentName = "Unknown";
        Topic = "Unknown";
    }
    public Assignment(string StudentName, string Topic)
    {
        this.StudentName = StudentName;
        this.Topic = Topic;
    }
    public string GetSummary()
    {
        return $"Name: {StudentName} Topic: {Topic}";
    }
}