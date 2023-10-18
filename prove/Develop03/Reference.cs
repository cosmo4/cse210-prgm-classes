public class Reference
{
    // Attributes
    private string Book;
    private int Chapter;
    private int StartVerse;
    private int EndVerse;

    // Constructors
    public Reference(string completeReference)
    {
        string[] parts = completeReference.Split(' ');

        if (parts.Length != 2)
        {
            throw new ArgumentException("Invlaid reference format. Must be 'Book Chapter:Verse' or'Book Chapter:StartVerse-EndVerse'.");
        }

        Book = parts[0];

        string[] chapterVerseParts = parts[1].Split(':');
        if (chapterVerseParts.Length != 2)
        {
            throw new ArgumentException("Invlaid reference format. Must be 'Book Chapter:Verse' or'Book Chapter:StartVerse-EndVerse'.");
        }

        Chapter = int.Parse(chapterVerseParts[0]);

        string[] verseParts = chapterVerseParts[1].Split('-');
        if (verseParts.Length == 1)
        {
            StartVerse = int.Parse(verseParts[0]);
            EndVerse = StartVerse;
        }
        else if (verseParts.Length == 2)
        {
            StartVerse = int.Parse(verseParts[0]);
            EndVerse = int.Parse(verseParts[1]);
        }
        else
        {
            throw new ArgumentException("Invalid reference format. Must be 'Book Chapter:Verse' or 'Book Chapter:StartVerse-EndVerse'");
        }
    }
    
    // Behaviors
    public bool IsSingleVerse()
    {
        return StartVerse == EndVerse;
    }

    public string GetReferenceType()
    {
        return IsSingleVerse() ? "Single Verse" : "Multiple Verses";
    }
}