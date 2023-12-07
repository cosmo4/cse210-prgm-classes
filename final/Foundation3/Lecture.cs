public class Lecture : Event
{
    // attributes/properties
    private string _lecturer;
    private int _capacity;

    // constructor
    public Lecture(string title, string description, string date, string time, string address, string lecturer, int capacity) : base("Lecture", title, description, date, time, address)
    {
        _lecturer = lecturer;
        _capacity = capacity;
    }

    // methods
    public string GetLecturer()
    {
        return _lecturer;
    }

    public int GetCapacity()
    {
        return _capacity;
    }

    public override string GetFullDetails()
    {
        return $"{_eventType} by:\n{_lecturer}\n{GetStandardDetails()}\nCapacity: {_capacity}";
    }

}