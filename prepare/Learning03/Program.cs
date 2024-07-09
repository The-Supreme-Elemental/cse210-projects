using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(5);
        Fraction f3 = new Fraction(7, 8);

        // Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        // f1.SetTop(3);
        // f1.SetBottom(4);
        // Console.WriteLine(f1.GetTop());
        // Console.WriteLine(f1.GetBottom());
    }
}