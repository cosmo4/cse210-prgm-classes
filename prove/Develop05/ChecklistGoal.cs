public class ChecklistGoal : Goal
{
    // attributes
    private int numerator;
    private int denominator;
    private int bonusPoints;
    
    // constructors

    // For loading a checklist goal
    public ChecklistGoal(string Type, string Name, string Description, int PointValue, bool IsDone, int Numerator, int Denominator, int BonusPoints) : base(Type, Name, Description, PointValue, IsDone)
    {
        numerator = Numerator;
        denominator = Denominator;
        bonusPoints = BonusPoints;
    }

    // For creating a new one (numerator set to 0)
    public ChecklistGoal(string Name, string Description, int PointValue, int Denominator, int BonusPoints) : base("Checklist", Name, Description, PointValue, false)
    {
        numerator = 0;
        denominator = Denominator;
        bonusPoints = BonusPoints;
    }

    // methods
    public override int RecordEvent(int points)
    {
        numerator += 1;
        if (IsComplete())
        {
            IsDone = true;
            return points + PointValue + bonusPoints;
        }
        else
        {
            IsDone = false;
            return points + PointValue;
        }
    }
    public override bool IsComplete()
    {
        if (numerator == denominator) 
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
            return $"[X] {Name} ({Description}) -- Currently Completed: {numerator}/{denominator}";
        }
        else
        {
            return $"[ ] {Name} ({Description}) -- Currently Completed: {numerator}/{denominator}";
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
            { "IsDone", IsDone },
            { "Numerator", numerator },
            { "Denominator", denominator },
            { "BonusPoints", bonusPoints }
        };
    }
}