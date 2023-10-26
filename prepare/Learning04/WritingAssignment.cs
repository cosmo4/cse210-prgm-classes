public class WritingAssignment : Assignment
{
    private string Title { get; set; }

    public WritingAssignment()
    {
        Title = "Null";
    }
    public WritingAssignment(string StudentName, string Topic, string Title)
    {
        this.StudentName = StudentName;
        this.Topic = Topic;
        this.Title = Title;
    }

    public string GetWritingInformation()
    {
        return $"{Title} by {StudentName}";
    }
}