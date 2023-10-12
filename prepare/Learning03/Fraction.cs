
public class Fraction
{
    // Attributes
    private int Top { get; set; }
    private int Bottom { get; set; }

    // Constructors
    public Fraction()
    {
        Top = 1;
        Bottom = 1;
    }
    public Fraction(int wholeNumber)
    {
        Top = wholeNumber;
        Bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        Top = top;
        Bottom = bottom;
    }

    // Methods
    public string GetFractionString()
    {
        return $"{Top}/{Bottom}";
    }
    public double GetDecimalValue()
    {
        return Top / (double)Bottom;
    }
}