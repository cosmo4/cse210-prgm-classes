using System;

public class Entry
{
    // properties
    public string Response { get; set; }
    public List<string> Responses { get; set; }
    public string Prompt { get; set; }
    public DateTime Today { get; set; }

    public Entry()
    {
        Responses = new List<string>();
    }
    
    // methods
    public void SaveResponse()
        {
            string entry = $"{DateTime.Today} - {Prompt}:\n{Response}";
            Responses.Add(entry);
        }

    public string GeneratePrompt(List<string> prompts)
    {
        var random = new Random();
        string randPrompt = prompts[random.Next(prompts.Count)];
        return randPrompt;
    }

    public void DisplayResponses()
    {
        foreach (var item in Responses)
        {
            Console.WriteLine($"{item}\n");
        }
        
    }

}