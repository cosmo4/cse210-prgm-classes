public class SimpleGoal : Goal
{
    public SimpleGoal(string Type, string Name, string Description, int PointValue, bool IsDone) : base(Type, Name, Description, PointValue, IsDone)
    {
    }
    public SimpleGoal(string Name, string Description, int PointValue) : base("Simple", Name, Description, PointValue, false)
    {
        
    }
    public override int RecordEvent(int points)
    {
        IsDone = true;
        return points + PointValue;
    }
    public override bool IsComplete()
    {
        if (IsDone)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public override string DisplayGoal()
    {
        if (IsComplete())
        {
            return $"[X] {Name} ({Description})";
        }
        else
        {
            return $"[ ] {Name} ({Description})";
        }
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