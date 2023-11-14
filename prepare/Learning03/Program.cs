using System;

class Program
{
    static void Main(string[] args)
    {
    Fraction f1 = new Fraction();
    f1.SetNumerator(1);
    f1.SetDenominator(1);
    Fraction f2 = new Fraction();
    f2.SetNumerator(5);
    f2.SetDenominator(1);
    Fraction f3 = new Fraction();
    f3.SetNumerator(3);
    f3.SetDenominator(4);
    Fraction f4 = new Fraction();
    f4.SetNumerator(1);
    f4.SetDenominator(3);

    Console.WriteLine($"{f1.GetFraction()}, {f1.GetDecimal()}");
    Console.WriteLine($"{f2.GetFraction()}, {f2.GetDecimal()}");
    Console.WriteLine($"{f3.GetFraction()}, {f3.GetDecimal()}");
    Console.WriteLine($"{f4.GetFraction()}, {f4.GetDecimal()}");
    }

}