using System.Text.Json.Serialization;

public abstract class Goal
{
    // attributes
    protected string Type;
    protected string Name;
    protected string Description;
    protected int PointValue;
    protected bool IsDone;

    // constructors
    [JsonConstructor]
    public Goal(string Type, string Name, string Description, int PointValue, bool IsDone)
    {
        this.Type = Type;
        this.Name = Name;
        this.Description = Description;
        this.PointValue = PointValue;
        this.IsDone = IsDone;
    }
    

    // methods
    public string Congrats()
    {
        string message = $"Congratulations! You completed your {Type} goal, {Name}.";
        return message;
    }
    public abstract int RecordEvent(int points);
    public abstract bool IsComplete();
    public abstract string DisplayGoal();
    public abstract Dictionary<string, object> SaveData();
}