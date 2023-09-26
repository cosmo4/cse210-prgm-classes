public class Job 
{
    // Properties defined here
    public string Company;
    public string JobTitle;
    public int StartYear;
    public int EndYear;

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