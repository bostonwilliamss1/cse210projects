public class Fraction
{
    private double _numerator;
    private double _denominator;

    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }

    public Fraction(double numerator)
    {
        _numerator = numerator;
        _denominator = 1;
    }

    public Fraction(double numerator, double denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }

    public double GetNumerator()
    {
        return _numerator;
    }

    public void SetNumerator(int numerator)
    {
        _numerator = numerator;
    }

    public double GetDenominator()
    {
        return _denominator;
    }

    public void SetDenominator(int denominator)
    {
        _denominator = denominator;
    }

    public string GetFraction()
    {
        return _numerator + "/" + _denominator;
    }

    public double GetDecimal()
    {
        return _numerator/_denominator;
    }
}