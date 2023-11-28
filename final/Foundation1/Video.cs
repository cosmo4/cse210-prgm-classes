public class Video
{
    // attributes
    public string title;
    public string author;
    public int length;
    public List<Comment> comments = new();

    // constructor
    public Video(string title, string author, int length, List<Comment> comments)
    {
        this.title = title;
        this.author = author;
        this.length = length;
        this.comments = comments;
    }

    // methods
    public int GetCommentCount()
    {
        return comments.Count;
    }

}