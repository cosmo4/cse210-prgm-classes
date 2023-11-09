public class Circle : Shape
{
    private double Radius;

    public Circle(string Color, double Radius) : base(Color)
    {
        this.Radius = Radius;
    }

    public override double GetArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}