public abstract class Shape
{
    protected string Color;

    public Shape(string Color)
    {
        this.Color = Color;
    }

    public string GetColor()
    {
        return Color;
    }
    public void SetColor(string Color)
    {
        this.Color = Color;
    }

    public abstract double GetArea();
}