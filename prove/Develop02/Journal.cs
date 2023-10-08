using System.IO;


public class Journal
{
    // properties
    public string UserName { get; set; }
    public List<string> Entries { get; set; }

    public Journal() 
    {
        Entries = new List<string>();
    }


    // methods
    public void SaveEntry(string filename)
    {
        using StreamWriter outputFile = new(filename);
        
        outputFile.WriteLine($"{Entries}");
    }
}