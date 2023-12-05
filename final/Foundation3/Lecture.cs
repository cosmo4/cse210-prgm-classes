public class Lecture : Event
{
    // attributes/properties
    private string lecturer;
    private int capacity;

    // constructor
    public Lecture(string title, string description, string date, string time, string address, string lecturer, int capacity) : base("Lecture", title, description, date, time, address)
    {
        this.lecturer = lecturer;
        this.capacity = capacity;
    }

    // methods
    public string GetLecturer()
    {
        return lecturer;
    }

    public int GetCapacity()
    {
        return capacity;
    }

    public override string GetFullDetails()
    {
        return $"{eventType} by:\n{lecturer}\n{GetStandardDetails()}\nCapacity: {capacity}";
    }

}