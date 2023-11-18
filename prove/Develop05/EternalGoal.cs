public class EternalGoal : Goal
{
    public EternalGoal(string Type, string Name, string Description, int PointValue, bool IsDone) : base(Type, Name, Description, PointValue, IsDone)
    {
    }
    public EternalGoal(string Name, string Description, int PointValue) : base("Eternal", Name, Description, PointValue, false)
    {
    }

    // methods
    public override int RecordEvent(int points)
    {
        IsDone = false;
        return points + PointValue;
    }
    public override bool IsComplete()
    {
        return false;
    }
    public override string DisplayGoal()
    {
        return $"[ ] {Name} ({Description})";
    }
    public override Dictionary<string, object> SaveData()
    {
        return new Dictionary<string, object>
        {
            { "Type", Type },
            { "Name", Name },
            { "Description", Description },
            { "PointValue", PointValue },
            { "IsDone", IsDone }
        };
    }
}