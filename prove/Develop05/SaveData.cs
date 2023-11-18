public class SaveData
{
    public int Points { get; set; }
    public List<Goal> Goals { get; set; }

    public SaveData(int points, List<Goal> goals)
    {
        Points = points;
        Goals = goals;
    }
}