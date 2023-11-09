using System.Drawing;

public class Square : Shape
{
    private double Side;
    
    public Square(string Color, double Side) : base(Color)
    {
        this.Side = Side;
    }

    public override double GetArea()
    {
        return Side * Side;
    }
}