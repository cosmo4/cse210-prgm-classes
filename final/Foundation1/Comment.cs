public class Comment
{
    // attributes
    public string text;
    public string author;

    // constructor
    public Comment(string text, string author)
    {
        this.text = text;
        this.author = author;
    }

    // methods
    public string GetText()
    {
        return text;
    }

    public string GetAuthor()
    {
        return author;
    }
}