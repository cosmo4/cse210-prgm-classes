public class Job 
{
    // Properties defined here
    public string Company { get; set; }
    public string JobTitle { get; set; }
    public int StartYear { get; set; }
    public int EndYear { get; set; }

    // Constructor defined here
    // public Job()
    // {
    // }

    // Methods defined here
    public void DisplayJobInfo()
    {
        Console.WriteLine($"{JobTitle} ({Company}) {StartYear}-{EndYear}");
    }

}