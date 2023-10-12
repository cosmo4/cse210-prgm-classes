using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction = new Fraction();
        Fraction fraction2 = new Fraction(5);
        Fraction fraction3 = new Fraction(3, 4);

        Console.WriteLine($"{fraction.GetFractionString()}");
        Console.WriteLine($"{fraction.GetDecimalValue()}");

        Console.WriteLine($"{fraction2.GetFractionString()}");
        Console.WriteLine($"{fraction2.GetDecimalValue()}");

        Console.WriteLine($"{fraction3.GetFractionString()}");
        Console.WriteLine($"{fraction3.GetDecimalValue()}");
    }
}