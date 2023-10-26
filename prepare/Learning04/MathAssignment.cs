public class MathAssignment : Assignment
{
    private string TextbookSection { get; set; }
    private string Problems { get; set; }

    public MathAssignment()
    {
        TextbookSection = "null";
        Problems = "null";
    }
    public MathAssignment(string StudentName, string Topic, string TextbookSection, string Problems)
    {
        this.StudentName = StudentName;
        this.Topic = Topic;
        this.TextbookSection = TextbookSection;
        this.Problems = Problems;
    }

    public string GetHomeworkList()
    {
        return $"Section: {TextbookSection} Problems: {Problems}";
    }
}