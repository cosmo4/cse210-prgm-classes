public class Rectangle : Shape
{
    private double Length;
    private double Width;

    public Rectangle(string Color, double Width, double Length) : base(Color)
    {
        this.Width = Width;
        this.Length = Length;
    }

    public override double GetArea()
    {
        return Width * Length;
    }
}